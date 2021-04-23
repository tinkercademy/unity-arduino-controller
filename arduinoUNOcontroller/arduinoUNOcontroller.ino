//this code is for use with adruino UNO

const int pin_button1 = 8; // left
const int pin_button2 = 3; // right
//numbers here change depending on your input pin value



void setup() {
  Serial.begin(9600);

  pinMode(pin_button1, INPUT);
  pinMode(pin_button2, INPUT);

}

void loop() {

  // left button is pushed. 
  if(digitalRead(pin_button1)==HIGH){
    Serial.write(1); // Unity will read this value. The number you put here should correspond to the number unity checks for in the script
    Serial.flush();
    delay(20); // This delay is important - 20 should be enough for a smooth transition. 
    }

  // right button is pushed
  if(digitalRead(pin_button2)==HIGH){
    Serial.write(2); // Unity will read this value. The number you put here should correspond to the number unity checks for in the script
    Serial.flush();
    delay(20);
    }
//test the code out through serial monitor. If code is not working, 1)check that components are connected correctly and securely 2) change the value above from "HIGH" to "LOW" 
}
