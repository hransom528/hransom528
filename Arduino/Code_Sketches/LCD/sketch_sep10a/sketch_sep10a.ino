#include <LiquidCrystal.h>

// Pins
const int RS = 2;
const int RW = 3;
const int E = 4;
const int D4 = 5;
const int D5 = 6;
const int D6 = 7;
const int D7 = 8;

LiquidCrystal lcd(2, 3, 4, 5, 6, 7, 8);

void setup() {
  lcd.begin(16, 2);
  lcd.print("Hi");
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  
}
