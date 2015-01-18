
#include <LiquidCrystal.h>
#define softPower 2;
#define lcd4 4;
#define lcd5 5;
#define lcd6 6;
#define lcd7 7;
#define lcd8 8;
#define lcd9 9;
#define sensorTrig 11
#define sensorEcho 12
#define sensorRain A1


unsigned char buffer[64]; 
int count=0;     
String response="";
int incomingByte = 0;
String serverNumber;
int sensorValue = 0;
boolean raining = 0;
String passphrase = "";
String telemetryType = "tm";
String statusType = "st";
String commandType = "cm";
void setup()
{
 powerUp();
 Serial1.begin(19200);                 
 Serial.begin(19200);  
 pinMode(sensorTrig, OUTPUT);
  pinMode(sensorEcho, INPUT);  

}
void loop()
{
 if (Serial1.available())              
 {
   while(Serial1.available())           
   {
     buffer[count++]=Serial1.read();     
     if(count == 64)break;
 }
   Serial.write(buffer,count);            
   clearBufferArray();              
   count = 0;                      
 }
 if (Serial.available())            
   Serial1.write(Serial.read());      
   
  
}
void clearBufferArray()              
{
 for (int i=0; i<count;i++)
   { buffer[i]=NULL;}                  
}
void powerUp()
{
 pinMode(2, OUTPUT); 
 digitalWrite(2,LOW);
 delay(1000);
 digitalWrite(2,HIGH);
 delay(2000);
 digitalWrite(2,LOW);
 delay(3000);
}
void powerDown()
{
 pinMode(2, OUTPUT); 
 digitalWrite(2,LOW);
 delay(1000);
 digitalWrite(2,HIGH);
 delay(2000);
 digitalWrite(2,LOW);
 delay(3000);
}

void SendTelemetry()
{
 long telemetry = getSensorData();
 Serial1.print("AT+CMGF=1\r");    
 delay(100);
 Serial1.println("AT + CMGS = \"" + serverNumber + "\"");
 delay(100);
 Serial1.println(telemetryType + "," + passphrase + "," + String(telemetry) );
 delay(100);
 Serial1.println((char)26);
 delay(100);
 Serial1.println();
}

long getSensorData(){
  int loopCount = 0;
  long ave = 0;
  long sData[5];
  while(loopCount < 5){
  long duration, distance;
  digitalWrite(sensorTrig, LOW); 
  delayMicroseconds(2); 
  digitalWrite(sensorTrig, HIGH);

  delayMicroseconds(10); 
  digitalWrite(sensorTrig, LOW);
  duration = pulseIn(sensorEcho, HIGH);
  distance = (duration/2) / 29.1;
  
  if (distance >= 200 || distance <= 0){
    Serial.println("Out of range");
    return 0;
  }
  else {
    Serial.print(distance);
    Serial.println(" cm");
    sData[loopCount] = distance;
    loopCount++;
    
    }
  }
  ave = (sData[0] + sData[1] + sData[2] + sData[3] + sData[4] )/5;
  return ave;
}

void sendStatus(){

 String statusMsg ="" ;
 
 if(getGSMStatus() == 1){
 statusMsg = statusMsg + "gsmOn";
 }
 
   Serial1.print("AT+CMGF=1\r");    
 delay(100);
 Serial1.println("AT + CMGS = \"" + serverNumber + "\"");
 delay(100);
 Serial1.println(statusType + "," + passphrase + "," + statusMsg );
 delay(100);
 Serial1.println((char)26);
 delay(100);
 Serial1.println();
 
  
}
boolean getGSMStatus(){
String getResponse = "";
  Serial1.print("AT");
getResponse = Serial1.read();
if(getResponse == "OK"{
  return 1;
}
  
}

