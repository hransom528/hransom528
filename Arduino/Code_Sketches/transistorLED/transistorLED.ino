const int controlPin = 13;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(controlPin, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(controlPin, HIGH);
  delay(1);
  digitalWrite(controlPin, LOW);
}
