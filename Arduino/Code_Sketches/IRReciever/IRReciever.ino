#include <IRremote.h>

const int RECV_PIN = 11;
IRrecv irrecv(RECV_PIN);
decode_results results;

void setup(){
  Serial.begin(9600);
  irrecv.enableIRIn();
  //irrecv.blink13(true);
}

void loop(){
  if (irrecv.decode(&results)){
    int resultsValue = results.value;// Results of decoding are stored in result.value     
    Serial.println(" ");     
    Serial.print("Code: ");     
    Serial.println(resultsValue); //prints the value a a button press     
    Serial.println(" ");     
    irrecv.resume(); // Restart the ISR state machine and Receive the next value     
  }
}
