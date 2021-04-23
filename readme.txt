Arduino controller in unity. Includes a game (similar to beatsaber) for you to test out the controller. 
This version is tested on and supports both Arduino and Freaduino, and supports controllers ADkey board, potentiometer, buttons (small) on breadboard. 

Game controls: pressing the red buttons on ADkey board or changing the values on potentiometer will cause the player cube in game to move. 

How to set up the controller:
1) Set up your Arduino/Freaduino first. 
	a. If you are using the ADkey board/potentiometer, plug it in to the Freaduino/Arduino. Connect the GVS on the freaduino to the GVS on the controller respectively. Take note that the "S" on the ADkey board (written as OUT for potentiometer) should be connected to A0 Pin. 
	b. If you are using 2 buttons on breadboard, plug it in to the Freaduino/Arduino and make sure that the input is at pin 8 and 3 respectively. 
*G=Ground ; V=voltage ; S=Signal (input/output)

2)a.If you are using ADkeyboard/potentiometer, open UNOfreaduinocontroller.ino 
  b.If you are using buttons on breadboard, open arduinoUNOcontroller.ino 

3)Setup the correct port (Arduino -> tools -> port) and under boards choose the board "Arduino UNO" (Arduino -> tools -> board) for both Freaduino and Arduino. 

4)Click the upload button to upload to your Arduino/Freaduino (make sure it is plugged in to your computer). Open up the serial monitor and if the setup is done correctly, numbers will appear on the serial monitor (for buttons on breadboard) and symbols will appear on the serial monitor (for ADkey board and potentiometer).

5)Open the project arduinogame_unity in unity 2020.1.17f1. DO NOT downgrade the project (use unity version 2020.1.17f1 or higher). 

6)Go to the C# script titled "adruino.sln" under arduinogame_unity folder and edit the "/dev/tty.usbmodem14101" with your own port number "/dev/tty.usbmodemXXXXX". This port number can be viewed under Arduino->tools->port. 

7)a. If you are using ADkey board, test out the controller by clicking the play button. 
  b. If you are using potentiometer/small buttons on breadboard, edit the values as instructed in the C# script titled "adruino.sln". 

8)If setup is done correctly you should be able to move the cube left and right in the game. In this game, the player cube will destroy incoming cubes on collision. 

Additional information
1)potentiometer produces output with range 0-255
2)Adkey board produces output values 0, 11,22, 32, 136, 255
3)buttons on breadboard produces values 1 or 2. 


For a more detailed setup and explanations, please refer to document titled "user manual"


Done by Si Qi 