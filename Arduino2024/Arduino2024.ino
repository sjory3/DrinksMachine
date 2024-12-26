
/*
    simple rotation of the motor
    the gear ration on the carousel is
    7/40 and there is 10 slots to rotate between
    


*/


//define Pins
#define PulPin 7
#define dirPin 6
int pd = 500;

void setup() {

  pinMode(PulPin, OUTPUT);
  pinMode(dirPin, OUTPUT);
  
}

void loop() {
  
  digitalWrite(dirPin, HIGH);
  digitalWrite(PulPin, HIGH);
  delayMicroseconds(pd);
  digitalWrite(PulPin, LOW);
  delayMicroseconds(pd);
  
  
}
