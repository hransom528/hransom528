void setup() {
  pinMode(5, OUTPUT);
}

void loop() {
  //R
  dot();
  dash();
  dot();
  delay(2000);
  
  //A
  dot();
  dash();
  delay(2000);
  
  //N
  dash();
  dot();
  delay(2000);
}

//Blinks dash
void dash() {
  digitalWrite(5, HIGH);
  delay(3000); 
  digitalWrite(5, LOW);
  delay(1000);
}

//Blinks dot
void dot() {
  digitalWrite(5, HIGH);
  delay(1000);
  digitalWrite(5, LOW);
  delay(1000);
}
