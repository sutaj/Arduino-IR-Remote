# Arduino-IR-Remote 
# for NETFLIX / PLEX
Arduino sketch for PC ir remote and custom made software

FREE FOR NON COMMERCIAL USE ONLY !

Simple circuit for arduino remote.
Can be transfered from prototyping on arduino to some smaller chip
2 led's for indicating working modes 
  - one for Netflix / Plex mode
  - and one for Mouse / Remote mode (yeah... it can be simple wireless mouse :P )
1 IR led (i got mine from old VCR i think)
1 remote (any ir remote)
Arduino or some Atmega chip


To check your Remote codes just uncomment about 115 line:
    /* sprawdzanie stanu klawiszy...

      Serial.print("Przycisk:  0x");
      Serial.println(results.value, HEX);
    */
then check codes in serial monitor in Arduino IDE or your favorite IDE

Software is made in C#. It needs some options like saving all setting's, but i leaving this to you :)
Amazing thing is that you have this connected all the time via USB, so if you want make some changes, just opent your IDE and add them :)

Program is automaticly checking port on what is your reciver connected.

Most of comments is in Polish, but code is simple and can be understand. 
I will make english version later.

For compiling arduino sketch, you need IR library from: https://github.com/z3t0/Arduino-IRremote (thx to z3t0 btw!)


![netflx](https://user-images.githubusercontent.com/667242/27181880-bf63bae0-51d9-11e7-9a59-b8d7dcfff9d2.png)
![program](https://user-images.githubusercontent.com/667242/27181882-bf855e84-51d9-11e7-9da4-40af4232694b.png)
