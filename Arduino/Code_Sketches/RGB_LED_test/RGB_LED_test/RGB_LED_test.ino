const int redPin = 9;
const int bluePin = 10;
const int greenPin = 11;

void setup()
{
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
}

void loop()
{

  setColor(0, 255, 0);
  delay(1000);
  setColor(0, 0, 255);
  delay(1000);
  setColor(255, 0, 0);
  delay(1000);
  setColor(255, 0, 255);
  delay(1000);
  setColor(255, 255, 0);
  delay(1000);
  setColor(255, 255, 255);
  delay(1000);
  setColor(255, 60, 255);
  delay(1000);
  setColor(255, 124, 162);
  delay(1000);
 
}

void setColor(int redValue, int greenValue, int blueValue) {
  analogWrite(redPin, redValue);
  analogWrite(greenPin, greenValue);
  analogWrite(bluePin, blueValue);
}
