//Reads potentiometer on A0, varies blink rate for LED on 13, on/off switch 
void setup() {
  // put your setup code here, to run once:
  pinMode(13, OUTPUT); //Controls LED
  pinMode(A0, INPUT); //Reads pot
  pinMode(12, OUTPUT); //Controls pot
  pinMode(11, INPUT); //Reads switch
  
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println(analogRead(A0)); //Logs pot reading
  int potValue = analogRead(A0); //Saves pot reading
  int switchVal = digitalRead(11); //Saves switch setting

  //Detects if switch is on or off
  if (switchVal == 1){
    digitalWrite(12, HIGH);
    digitalWrite(13, HIGH);
    delay(potValue); //Varies blink speed based off pot value
    digitalWrite(13, LOW);
    delay(potValue); 
  } else {
    digitalWrite(13, LOW);
    digitalWrite(12, LOW);
  }
 
}
