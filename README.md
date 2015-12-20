Firmata + TCP 2 Serial + LittleBit for ESP8266/NodeMCU
========================================================================================================================
## This package solves these problems for ESP8266/NodeMCU:
  - Run Firmata (heavily modified fork of StandardFirmataEthernet) on NodeMCU accessible through Wifi
  - Access Firmata on NodeMCU through local serial port (Windows) that in fact connects to NodeMCU through Wifi
    (this is particularly useful if you want to connect other software to your NodeMCU that can only use COM port)
  - Make your own 'LittleBit' out of NodeMCU and control it from http://s4a.cat/snap/ (Snap4Arduino) wirelessely. 
    More to come later for schematics and control. If you don't know what littlebits are, check out https://littlebits.cc


Setup steps
========================================================================================================================
(uses pre-compiled files from https://github.com/kotl/littlebits-esp8266/ )
How to compile everything from source is explained below in this guide.

Step 1. Install ESP8266 driver from step1-esp8266-driver\CH341SER.EXE
  -- Please do not connect your ESP8266 until you get message for installing drivers succesfully.

Step 2. Install pre-compiled firmware. 
  -- Run step2-esp8266-firmware-flash\WinXX\ESP8266Flasher.exe 
  -- Go to Config tab and replace internal://nodeMCU entry with file
     step2-esp8266-firmware-flash\ESP8266FirmataWifi.ino.bin
     (as shown in step2-esp8266-firmware-flash\config.png )

Step 3. Setup virtual serial driver.
    - Install step3-com0com\com0com-2.2.2.0-x64-fre-signed package 
      (no need to run bcdedit.exe, these are signed drivers for 64-bit Windows)
       -- If you use 32-bit windows you will have to find appropriate package yourself.
    - Make sure to check 'Run Setup Command Prompt' at the end.
    - Configure com0com using command prompt:
	remove 0
        install PortName=COM100 PortName=COM101
        quit
    - Open Device Manager, you should see 3 items under com0com serial port emulators.
      If you don't -> something is wrong. May be wait longer, reboot, reinstall?
	  com0com - bus for serial port pair emulator
	  com0com - serial port emulator
	  com0com - serial port emulator

Step 4.
    - Run: comm2ip-master\Comm2IPService --install
       You may have to install .NET framework (it will ask you to).
       You may need to run this command in cmd.exe that was started as Administrator.
    - Go to Services and find Comm2IPService. click Start.

Step 5.
    - Configure your ESP8266 board using step5-configure/ESP8266Configurator.exe
      -- setup SSID, Password, IP of this host where comm2ip + com2com are setup, remote port should be 3030 unless
         you changed step4-comm2ip\Comm2IPService.exe.config

And now everything should work all the time through port COM101. 

How to use
========================================================================================================================
Unfortunately due to very unusual pinout of ESP8266, only these commands will work for ESP8266 Firmata:

1. Analog reading of pins 0,1,2,3 which correspond to the following pins on ESP8266:
 PIN0 A0 
 PIN1 D4
 PIN2 D5
 PIN3 D6

Analog reading for digital pins D4,D5,D6 will always give you either 0 (low) or 1023 (high) values.

2. PWM for pins 4,5,6,7 which correspond to the following pins on ESP8266:
 PIN4 D0
 PIN5 D1
 PIN6 D2
 PIN7 D3

If you want to operate these pins as digital, use 0 for LOW and 255 for HIGH. Otherwise it will work as PWM.

Only these 2 commands for pin control are supported (no digital pin commands or reusing PIN as different type).


How to compile
========================================================================================================================
How to compile various pieces of software that are used in this guide:

1. comm2ip: https://github.com/kotl/comm2ip
2. Configuration utility: https://github.com/kotl/littlebits-esp8266/configure-util
3. Flash utility: https://github.com/nodemcu/nodemcu-flasher
4. com2com driver: http://com0com.sourceforge.net/
5. Compile ESP8266 Firmware:

   - Install latest Arduino environment.
   - Follow instructions installing esp8266/Arduino using my own fork: https://github.com/kotl/esp8266
   - Replace libraries\Firmata with my own fork: https://github.com/kotl/esp8266-firmata
   - Install ESP8266 driver (Step 1 of this guide) (CH341SER.EXE).
     Please do not connect your ESP8266 until you get message for installing driving succesfully.
   - Connect your ESP8266. Choose proper board and port in Arduino environment.
   - Open https://github.com/kotl/esp8266-firmata/examples/ESP8266FirmataWifi/ESP8266FirmataWifi.ino in Arduino
   - Select your ESP8266 board. 
   - Compile and upload into your unit. You are done :)


