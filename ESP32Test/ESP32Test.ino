#include <Arduino.h>
#include <ESP32Servo.h>

Servo myServo;
int servoPin = 12;

void setup() {
  //myServo.attach(servoPin);
  //myServo.write(0);
  Serial.begin(115200);
  pinMode(2, OUTPUT);
}

void loop() {
  digitalWrite(13, HIGH);   
  Serial.write(High);
  delay(1000);              
  digitalWrite(13, LOW);
     
  Serial.write("Low");
  delay(1000);  
}