/***
       ▄▄▄       ██ ▄█▀ ██▓ ██▓
      ▒████▄     ██▄█▒ ▓██▒▓██▒
      ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░
      ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░
       ▓█   ▓██▒▒██▒ █▄░██░░██████▒
       ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
        ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
        ░   ▒   ░ ░░ ░  ▒ ░  ░ ░
            ░  ░░  ░    ░      ░  ░

*/

/* FREE FOR NON COMMERCIAL USE   O N L Y  ! */

/*
   pinouts

      IR LED
     vcc - +5V
     gnd - gnd
     data - arduino pin 2

     MODE INDICATOR LED:
     anode - resistor + +5V
     cathode - arduino pin 4

     MOUSE INDICATOR LED:
     anode - resistor + +5V rail
     cathode - arduino pin 5 (+uncomment line #48 and #103-112)

    for ir use library https://github.com/z3t0/Arduino-IRremote

*/

#include <Keyboard.h>
#include <Mouse.h>
#include <boarddefs.h>
#include <IRremote.h>
#include <IRremoteInt.h>
#include <ir_Lego_PF_BitStreamEncoder.h>


#define irPin 2
#define NPPin 4
// Jeśli chcesz diodę przełącznika pilot/mysz
// uncomment for remote/mouse indicator led
//#define KMPin 5

IRrecv irrecv(irPin);
decode_results results;

// zmienne do myszy
int X = 0;
int Y = 0;
bool Swch;    // określamy tryb Netflix / Plex
bool sMouse;   // a tu nadrzędny przełącznik - pilot / prymitywna myszka...
int mSpeed;
int incomingByte = 0;

void setup() {
  Serial.begin(9600);
  irrecv.enableIRIn();
  Mouse.begin();
  Keyboard.begin();
  pinMode(4, OUTPUT);
  Swch = false;
  sMouse = false;
  mSpeed = 5;

  // wysyłamy początkowe wiadomości do programu
  // jeśli nie potrzebujesz, komentuj wszystkie Serial.println()
  // checkin commands for software. don't want integrate with software? comment all Serial.pringln() lines :)
  Serial.println("x101." + String(Swch));
  delay(50);
  Serial.println("x102." + String(sMouse));
  delay(50);
}

void loop() {
  if (Serial.available() > 0) {
    incomingByte = Serial.read();
    
    switch (incomingByte){
    case 77: /* M - for mouse */
      Serial.println("x102." + String(sMouse));
        delay(50);
        break;

      case 84: /* T - for mode */
        Serial.println("x101." + String(Swch));
        delay(50);
        break;

      case 112: /* p - for mode: plex */
        Swch = false;
        delay(100);
        Serial.println("x101." + String(Swch));
        break;

      case 110: /* n - for mode : netflix */
        Swch = true;
        delay(100);
        Serial.println("x101." + String(Swch));
        break;
    }
  }

  if (Swch) {
    digitalWrite(NPPin, LOW);
    // NETFLIX
  } else {
    digitalWrite(NPPin, HIGH);
    // PLEX
  }

  // możesz dodać indykację stanu pilot/mysz
  // remote/mouse indicator...
  /*
    if (sMouse) {
    digitalWrite(KMPin, LOW);
    // MYSZKA
    } else {
    digitalWrite(KMPin, HIGH);
    // PILOT
    }
  */

  if (irrecv.decode(&results)) {

    /* sprawdzanie stanu klawiszy...

      Serial.print("Przycisk:  0x");
      Serial.println(results.value, HEX);
    */

    // wysyłanie danych przez serial przydatne jest do odbierania sygnałów w zewnętrznym programie
    // np. program wyświetlający infrormacje w OSD
    switch (results.value) {

      case 0xFD00FF:    // power - jako esc we wszystkich trybach.
        Keyboard.write(0xB1);
        Serial.println("x100");
        break;

      case 0xFDB04F: // zmiana trybu PLEX/NETFLIX
        Swch = !Swch;
        Serial.println("x101." + String(Swch));
        break;

      case 0xFDD02F: // button [-/--] change mode remote / mouse
        sMouse = !sMouse;
        Serial.println("x102." + String(sMouse));
        break;

      case 0xFDE21D: // AUTO - left click
        if (sMouse) {
          Mouse.click();
          Serial.println("x103");
        }
        break;

      case 0xFDF00F: // INPUT - right click
        if (sMouse) {
          Mouse.click(MOUSE_RIGHT);
          Serial.println("x104");
        }
        break;

      case 0xFD6897:    // menu - show clock.
        Serial.println("x130");
        break;

      case 0xFD807F: // mute
        if (!sMouse) {
          if (Swch) { // NETFLIX
            Keyboard.write('M');
            Serial.println("x105");
          } else { // PLEX
            // brak klawisza mute
          }
        }
        break;

      case 0xFD48B7: // prawo
        if (sMouse) {
          // myszka
          Mouse.move(X + mSpeed, Y, 0);
        } else {
          // pilot
          if (Swch) { // NETFLIX
            // w netflixie pojawia się bug, który nie zawsze aktualizuje pozycję odtwarzanego filmu
            // pauza filmu przed przesunięciem, powinna pominąć ten bug.
            // ale zależy to też od szybkości komputera docelowego...
            // UPDATE FIX: dla nowej wersji odtwarzacza z 08.2017

            // netflix webplayer bugfix
            Keyboard.write(KEY_RETURN);
            delay(15);
            Keyboard.write(KEY_RIGHT_ARROW);
            delay(15);
            Keyboard.write(KEY_RETURN);
            delay(15);
            Keyboard.write(KEY_RETURN);
          } else { // PLEX
            Keyboard.write(46);
          }
          Serial.println("x106");
        }
        break;

      case 0xFD28D7: // dół
        if (sMouse) {
          // myszka
          Mouse.move(X, Y + mSpeed , 0);
        }
        Serial.println("x107");
        break;

      case 0xFD8877: // lewo
        if (sMouse) {
          // myszka
          Mouse.move(X - mSpeed, Y, 0);
        } else {
          // pilot
          if (Swch) { // NETFLIX
            // w netflixie pojawia się bug, który nie zawsze aktualizuje pozycję odtwarzanego filmu
            // pauza filmu przed przesunięciem, powinna pominąć ten bug.
            // ale zależy to też od szybkości komputera docelowego...
            // UPDATE FIX: dla nowej wersji odtwarzacza z 08.2017

            // netflix webplayer bugfix
            Keyboard.write(KEY_RETURN);
            delay(15);
            Keyboard.write(KEY_LEFT_ARROW);
            delay(15);
            Keyboard.write(KEY_RETURN);
            delay(15);
            Keyboard.write(KEY_RETURN);
          } else { // PLEX
            Keyboard.write(44);
          }
          Serial.println("x108");
        }
        break;

      case 0xFDC837: // góra
        if (sMouse) {
          // myszka
          Mouse.move(X, Y - mSpeed , 0);
        }
        Serial.println("x109");
        break;

      case 0XFD08F7: // enter
        if (!sMouse) {
          if (Swch) { // NETFLIX
            Keyboard.write(32);
          } else { // PLEX
            Keyboard.write(32);
          }
        }
        Serial.println("x110");
        break;

      case 0xFD12ED: // vol+
        if (sMouse) {
          // myszka
          mSpeed += 5;
          Serial.println("M+" + String(mSpeed));
        } else {
          // pilot
          Keyboard.press(0xDA);
          delay(30);
          Keyboard.releaseAll();
          Serial.println("x111");
        }
        break;

      case 0xFD926D: // vol-
        if (sMouse) {
          // myszka
          mSpeed -= 5;
          Serial.println("M-" + String(mSpeed));
        } else {
          // pilot
          Keyboard.press(0xD9);
          delay(30);
          Keyboard.releaseAll();
          Serial.println("x112");
        }
        break;

      case 0xFD52AD: // CH+
        if (!sMouse) {
          if (Swch) { // NETFLIX
            // na razie nie ma odpowiednika
          } else { // PLEX
            Keyboard.write(KEY_RIGHT_ARROW);
            Serial.println("x113");
          }
        }
        break;

      case 0xFDD22D: // CH-
        if (!sMouse) {
          if (Swch) { // NETFLIX
            // na razie nie ma odpowiednika
          } else { // PLEX
            Keyboard.write(KEY_LEFT_ARROW);
            Serial.println("x114");
          }
        }
        break;

      case 0xFDA857: // exit
        if (!sMouse) {
          if (Swch) { // NETFLIX
            Keyboard.write(70);
          } else { // PLEX
            Keyboard.write(92);
          }
        }
        Serial.println("x115");
        break;

      case 0xFD38C7: // [PC] - show program (if running)
        Serial.println("x911");
        break;

      case 0xFDB847: // [AV] - switch auto mode option in program (if running)
        Serial.println("x200");
        break;

      case 0xFD40BF: // 1
        Keyboard.write(49);
        Serial.println("x116");
        break;

      case 0xFDC03F: // 2
        Keyboard.write(50);
        Serial.println("x117");
        break;

      case 0xFD20DF: // 3
        Keyboard.write(51);
        Serial.println("x118");
        break;

      case 0xFDA05F: // 4
        Keyboard.write(52);
        Serial.println("x119");
        break;

      case 0xFD609F: // 5
        Keyboard.write(53);
        Serial.println("x120");
        break;

      case 0xFDE01F: // 6
        Keyboard.write(54);
        Serial.println("x121");
        break;

      case 0xFD10EF: // 7
        Keyboard.write(55);
        Serial.println("x122");
        break;

      case 0xFD906F: // 8
        Keyboard.write(56);
        Serial.println("x123");
        break;

      case 0xFD50AF: // 9
        Keyboard.write(57);
        Serial.println("x124");
        break;

      case 0xFD30CF: // 0
        Keyboard.write(48);
        Serial.println("x125");
        break;

      case 0xFD32CD: // czerwony
        Keyboard.press(KEY_LEFT_GUI);
        delay(25);
        Keyboard.press('r');
        delay(25);
        Keyboard.releaseAll();
        delay(25);
        Keyboard.print("https://netflix.com/pl/");
        Keyboard.press(0xB0);
        Serial.println("x126");
        break;

      case 0xFDB24D: // zielony
        Keyboard.press(KEY_LEFT_GUI);
        delay(25);
        Keyboard.press('r');
        delay(25);
        Keyboard.releaseAll();
        delay(25);
        Keyboard.print("http://127.0.0.1:32400/web/index.html");
        Keyboard.press(0xB0);
        Serial.println("x127");
        break;

      case 0xFD728D: // żółty
        Keyboard.press(KEY_LEFT_GUI);
        delay(25);
        Keyboard.press('r');
        delay(25);
        Keyboard.releaseAll();
        delay(25);
        Keyboard.print("https://www.youtube.com/");
        Keyboard.press(0xB0);
        Serial.println("x128");
        break;

      case 0xFDF20D: // niebieski
        Keyboard.press(KEY_LEFT_GUI);
        delay(25);
        Keyboard.press('r');
        delay(25);
        Keyboard.releaseAll();
        delay(25);
        Keyboard.print("https://www.wp.pl/");
        Keyboard.press(0xB0);
        Serial.println("x129");
        break;

    }
    irrecv.resume();
    //digitalWrite(LED_BUILTIN, LOW);
  }
}
