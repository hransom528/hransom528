int pinTemp = A1;   //This is where our Output data goes

void setup() {
  Serial.begin(9600);     
}
void loop() {
  int temp = analogRead(pinTemp);    //Read the analog pin
  Serial.println(temp);
  delay(1000);  
}
