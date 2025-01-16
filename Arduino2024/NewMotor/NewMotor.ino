#include <MobaTools.h>

const byte stepPin = 9;
const byte dirPin = 8;
//const byte enablePin = 8;


//steps per position
long pos1 = 0;
long pos2 = 828;
long pos3 = 1656;
long pos4 = 2484;
long pos5 = 3312;
long pos6 = 4140;
long pos7 = 4968;
long pos8 = 5796;
long pos9 = 6624;
long pos10 = 7452;

int stepsToMove = 828;
unsigned long stepDelay = 1000; // milliseconds

MoToStepper stepper( 400, STEPDIR );

void setup()
{
   Serial.begin(9600);

   stepper.attach( stepPin, dirPin );   
   stepper.setSpeedSteps(20000);  // = 75 steps/second (steps in 10 seconds)
   stepper.setRampLen(500);
   stepper.setZero();
}

void loop()
{
    stepper.moveTo(pos9);
    while(stepper.distanceToGo() > 0);
    Serial.write("current position :");
    delay(stepDelay);
    stepper.moveTo(pos2);
    while(stepper.distanceToGo() > 0);
    delay(stepDelay);
    stepper.moveTo(pos5);
    while(stepper.distanceToGo() > 0);
    delay(stepDelay);
    stepper.moveTo(pos3);
    while(stepper.distanceToGo() > 0);
    
    delay(stepDelay);
    
}