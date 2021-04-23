void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
}

// the loop routine runs over and over again forever:
void loop() {
  // read the input on analog pin 0 (changes depending on where your input pin is at)
  int sensorValue = analogRead(A0);
  int sensor2 = sensorValue / 4 ;
  // for ADkeyboard and potentiometer, output range is 0-1023. Since we are converting it to byte, division by 4 is needed. 
  // print out the value you read:
//Serial.println(sensor2) is not used as unity reads serial.write()
Serial.write(sensor2);
Serial.flush();
  delay(10);  
        // delay in between reads for stability
}
