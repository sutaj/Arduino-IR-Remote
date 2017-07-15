# Arduino-IR-Remote 
# for NETFLIX / PLEX
Arduino sketch for PC ir remote and custom made software

FREE FOR NON COMMERCIAL USE ONLY !


Simple circuit for arduino remote.
Can be transfered from prototyping on arduino to some smaller chip

# Arduino connections
2 led's for indicating working modes 
  - one for Netflix / Plex mode
  - and one for Mouse / Remote mode (yeah... it can be simple wireless mouse :P )
1 IR led (i got mine from old VCR i think)
1 remote (any ir remote)
Arduino or some Atmega chip


IR LED 
 *   vcc -> +5V
 *   gnd -> gnd
 *   out -> arduino pin 2
     
 *   MODE INDICATOR LED:
 *   anode -> resistor + +5V
 *   cathode -> arduino pin 4
     
 *   MOUSE INDICATOR LED:
 *   anode -> resistor -> +5V rail
 *   cathode -> arduino pin 5 (+uncomment line #48 and #103-112 in sketch)


To check your Remote codes just uncomment about 115 line:
    
```C
    /* sprawdzanie stanu klawiszy...

      Serial.print("Przycisk:  0x");
      Serial.println(results.value, HEX);
    */
```
    
then check codes in serial monitor in Arduino IDE or your favorite IDE

# Windows program

(program was tested only on Windows 10 but on Windows 7,8 should be fine)

Software is made in C# 7 (.NET framework 4.7+). It needs some options like saving all setting's, but i leaving this to you :)
Amazing thing is that you have this ir reciver connected all the time via USB, so if you want make some changes, just opent your IDE and add them :)

Program is automaticly checking port on what is your reciver connected.

Most of comments is in Polish, but code is simple and can be understand. 
I will make english version later.
* 90% is now english or have english translations commented out.

## Changelog
**17-06-2017**:

      * Stepup to .NET Framework 4.7
      
      * Multi language (need to be fixed - now is as strings in class)
      
      * Bugfix when check buttons didn't work correcly
      
      * othe minor bugfixes...
      
**21-06-2017**:
      
      * Communication indicator
      
      * Moved OSD to new thread, so it will be smoother now
      

For compiling arduino sketch, you need IR library from: https://github.com/z3t0/Arduino-IRremote (thx to z3t0 btw!)

![20170615_170813](https://user-images.githubusercontent.com/667242/27188365-373f9bf6-51ee-11e7-9fa5-0ab6333d29df.png)

![prototype](https://user-images.githubusercontent.com/667242/27188366-375cec7e-51ee-11e7-9433-fae0f8e78bf7.png)

![netflx](https://user-images.githubusercontent.com/667242/27181880-bf63bae0-51d9-11e7-9a59-b8d7dcfff9d2.png)

![program](https://user-images.githubusercontent.com/667242/27195516-67b23fd2-5207-11e7-8bbe-9c23b0e6a22c.png)
