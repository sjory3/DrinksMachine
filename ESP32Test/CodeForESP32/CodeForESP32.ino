#include <Stepper.h> 

#define STEPS 200
#define motorInterfaceType 1

//------stepper motor for carousel----------
Stepper stepper(STEPS, 2, 3); // Pin 2 connected to DIRECTION & Pin 3 connected to STEP Pin of Driver
int stepperSleepPin = 0;
int stepperCounter = 0;

//------linear actuator for doseing-----------
int doesActivatePin = 0;
int doesDeactivatePin = 0;


void setup() {
  stepper.setSpeed(1000);
  pinMode(stepperSleepPin, OUTPUT);
  //Sleeps motor to stop overheating
  digitalWrite(stepperSleepPin, HIGH);

  pinMode(doesActivatePin, OUTPUT);
  pinMode(doesDeactivatePin, OUTPUT);
}

void loop() {

  //-------Wait for MQTT BROKER message--------//

}

//-------------Dosing valve activation----------------//
void doesAlcohol(){
  digitalWrite(doesActivatePin, HIGH);
  delay(5000);
  digitalWrite(doesActivatePin, LOW);
  digitalWrite(doesDeactivatePin, HIGH);
  delay(2000);
  digitalWrite(doesDeactivatePin, LOW);
  
  
  //Send message for done doesing
}


//-------------Carousel activation----------------//

void runCarousel(int steps){
  //Wakes up motor to run
  digitalWrite(stepperSleepPin, LOW);

  //---------Add acceleration to save motor from inertia from the carousel--------//
  
  stepper.step(steps);
  stepperCounter = stepperCounter + steps;

  //Sleeps motor to stop overheating
  digitalWrite(stepperSleepPin, HIGH);

  //Send message for done runing
}


//-------------Pumps activation----------------//

void activatePump(int pump, int time){
  
  pinMode(pump, OUTPUT);
  digitalWrite(pump, HIGH);
  delay(time);
  digitalWrite(pump, LOW);
  //Send message for done pumping
}














