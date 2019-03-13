const int ledPin = 13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(250000);
  pinMode(ledPin, OUTPUT);

  countDown(5);
}

void loop() {
  // put your main code here, to run repeatedly:
  static int delayPeriod = 1000;
  static int countDir = 1;

  //Changes output to high or low 
  digitalWrite(ledPin, HIGH);
  delay(delayPeriod);
  digitalWrite(ledPin, LOW);
  delay(delayPeriod);

  countDir = checkDirChange(delayPeriod, countDir);

  delayPeriod += 100 * countDir; 
  Serial.print("New Wait Time : ");
  Serial.println(delayPeriod);
}

int checkDirChange(int delayPeriod, int countDir) {
 if ((delayPeriod == 1000) or (delayPeriod == 0)) {
     //Speeds up and slows down delay
     countDir *= -1;

     if (countDir < 0) {
      Serial.println("Going Down");
     } else {
      Serial.println("Going Up");
     }
  }
  return countDir;
}

void countDown(int max) {
  for(int i = max; i > 0; i--) {
    Serial.print(i);
    Serial.print(", ");
  }
  Serial.println("Go! \n");
}
