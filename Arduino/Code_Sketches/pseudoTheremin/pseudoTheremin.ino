/*
Adafruit Arduino - Lesson 10. Pseudo Thermin
*/
 
int speakerPin = 12;
int photocellPin = 0;
 
void setup()
{
}
 
void loop()
{
  int reading = analogRead(photocellPin);
  int pitch = 200 + reading / 4;
  tone(speakerPin, pitch);
}
