
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

//TeamSpeak
byte server[]  = { 184, 106, 153, 149 }; // IP Address for the ThingSpeak API
String writeAPIKey = "PDK34R7M5G3LYX4Z";    // Write API Key for a ThingSpeak Channel
const int updateInterval = 30000;        // Time interval in milliseconds to update ThingSpeak   
Client client(server, 80);


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
void sendToThingSpeak()
{
 Serial1.println("AT+CGATT?");
 delay(100);
 ShowSerialData();
 Serial1.println("AT+CSTT=\"CMNET\"");//start task and setting the APN,
 delay(1000);
 ShowSerialData();
 Serial1.println("AT+CIICR");//bring up wireless connection
 delay(300);
 ShowSerialData();
 Serial1.println("AT+CIFSR");//get local IP adress
 delay(2000);
 ShowSerialData();
 Serial1.println("AT+CIPSPRT=0");
 delay(3000);
 ShowSerialData();
 Serial1.println("AT+CIPSTART=\"tcp\",\"api.cosm.com\",\"8081\"");//start up the connection
 delay(2000);
 ShowSerialData();
 Serial1.println("AT+CIPSEND");//begin send data to remote server
 delay(4000);
 ShowSerialData();
 String humidity = "1031";//these 4 line code are imitate the real sensor data, because the demo did't add other sensor, so using 4 string variable to replace.
 String moisture = "1242";//you can replace these four variable to the real sensor data in your project
 String temperature = "30";//
 String barometer = "60.56";//
 Serial1.print("POST /update HTTP/1.1\n");//here is the feed you apply from pachube
 delay(500);
 ShowSerialData();
 Serial1.print("Host: api.thingspeak.com\n");
 delay(500);
 ShowSerialData();
 Serial1.print("Connection: close\n");
 delay(500);
 ShowSerialData();
 Serial1.print("X-THINGSPEAKAPIKEY: "+writeAPIKey+"\n");
 delay(500);
 ShowSerialData();
 Serial1.print("Content-Type: application/x-www-form-urlencoded\n");
 delay(500);
 ShowSerialData();
 Serial1.print("Content-Length: ");
 delay(500);
 ShowSerialData();
 Serial1.println(tsData.length());
 delay(500);
 ShowSerialData();
  Serial1.println("\n\n");
 delay(500);
 ShowSerialData();
  Serial1.println(tsData);
 delay(500);
 ShowSerialData();
 lastConnectionTime = millis();
    
    resetCounter = 0;

 
 Serial1.println(tsData.length());
 delay(500);
 ShowSerialData();
 Serial1.println("{\"id\": \"02\",\"current_value\": \"" + humidity + "\"},");
 delay(500);
 ShowSerialData();
 Serial1.println("{\"id\": \"03\",\"current_value\": \"" + moisture + "\"},");
 delay(500);
 ShowSerialData();
 Serial1.println("{\"id\": \"04\",\"current_value\": \"" + temperature + "\"}]},\"token\": \"lee\"}");
 delay(500);
 ShowSerialData();
 Serial1.println((char)26);//sending
 delay(5000);//waitting for reply, important! the time is base on the condition of internet 
 Serial1.println();
 ShowSerialData();
 Serial1.println("AT+CIPCLOSE");//close the connection
 delay(100);
 ShowSerialData();
}
void ViewSerialResponse()
{
 while(Serial1.available()!=0)
   Serial.write(Serial1.read());
}
