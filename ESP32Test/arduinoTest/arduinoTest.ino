#include <Stepper.h> 

#define STEPS 200

Stepper stepper(STEPS, 2, 3); // Pin 2 connected to DIRECTION & Pin 3 connected to STEP Pin of Driver

#define motorInterfaceType 1

int btnPin = 5;
int ledPin = 6;
int buttonState = 0;

void setup() {

  stepper.setSpeed(1600);
  pinMode(btnPin, INPUT);
  pinMode(ledPin, OUTPUT);
}

void loop() {

  buttonState = digitalRead(btnPin);

  if(buttonState == HIGH){
    digitalWrite(ledPin, HIGH);
    stepper.step(1);

    //delay(5000);
    
    //stepper.step(-800);
  }
  else{
    digitalWrite(ledPin, LOW);
  }

  

}