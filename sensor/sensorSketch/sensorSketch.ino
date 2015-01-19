#include <Dhcp.h>
#include <Dns.h>
#include <Ethernet.h>
#include <EthernetClient.h>
#include <EthernetServer.h>
#include <EthernetUdp.h>
#include <util.h>
#include <SPI.h>

#include <LiquidCrystal.h>
#include <SD.h>

#define softPower 2
#define lcd4 4
#define lcd5 5
#define lcd6 6
#define lcd7 7
#define lcd8 8
#define lcd9 9
#define lcd10 10
#define eth11 11
#define eth12 12
#define eth13 13
#define lcdKey A0
#define floodTrig 19
#define floodEcho 20
#define sensorRain 21


unsigned char buffer[64]; 
int count=0;     
String response="";
int incomingByte = 0;
String serverNumber;
long sensorValue = 0;
boolean rainValue = 0;
String passphrase = "";
String telemetryType = "tm";
String statusType = "st";
String commandType = "cm";
int count1= 0;
String floodData = " ";
String rainData = " ";
long originalHeight = 0;
//TeamSpeak
byte server[]  = { 184, 106, 153, 149 }; // IP Address for the ThingSpeak API
String writeAPIKey = "PDK34R7M5G3LYX4Z";    // Write API Key for a ThingSpeak Channel
const int updateInterval = 30000;        // Time interval in milliseconds to update ThingSpeak   



void setup()
{
 powerUp();
 Serial1.begin(19200);                 
 Serial.begin(19200);  
 pinMode(floodTrig,OUTPUT);
  pinMode(floodEcho, INPUT);  

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
   
sensorValue = originalHeight - getSensorData();
rainValue = getRainStatus();
floodData = String(sensorValue, DEC);
rainData  = String(rainValue, DEC);
Serial.println(floodData);

connectGPRS();
sendToThingSpeak("1=" + rainData + "&2=" + floodData);
delay(30000);

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
  digitalWrite(floodTrig, LOW); 
  delayMicroseconds(2); 
  digitalWrite(floodTrig, HIGH);

  delayMicroseconds(10); 
  digitalWrite(floodTrig, LOW);
  duration = pulseIn(floodEcho, HIGH);
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

if(getResponse == "OK"){
  return 1;
}
  
}

void connectGPRS(){
  Serial1.println("AT+CGATT?");
 delay(100);
 ViewSerialResponse();
 Serial1.println("AT+CSTT=\"http.globe.com.ph\"");
 delay(1000);
 ViewSerialResponse();
 Serial1.println("AT+CIICR");
 delay(300);
 ViewSerialResponse();
 Serial1.println("AT+CIFSR");
 delay(2000);
 ViewSerialResponse();
 Serial1.println("AT+CIPSPRT=0");
 delay(3000);
  ViewSerialResponse();
 Serial1.println("AT+CIPSTART=\"tcp\",\"api.thingspeak.com\",\"80\"");
 delay(2000);
 ViewSerialResponse();
  
}
void sendToThingSpeak(String tmData)
{
  
 //send to Thingspeak channel, field 1
 Serial1.println("AT+CIPSEND");
 delay(4000);
 ViewSerialResponse();
 Serial1.print("POST /update HTTP/1.1\n");
 delay(500);
 ViewSerialResponse();
 Serial1.print("Host: api.thingspeak.com\n");
 delay(500);
 ViewSerialResponse();
 Serial1.print("Connection: close\n");
 delay(500);
 ViewSerialResponse();
 Serial1.print("X-THINGSPEAKAPIKEY: "+writeAPIKey+"\n");
 delay(500);
 ViewSerialResponse();
 Serial1.print("Content -Type: application/x-www-form-urlencoded\n");
 delay(500);
 ViewSerialResponse();
 Serial1.print("Content-Length: ");
 delay(500);
 ViewSerialResponse();
 Serial1.print(tmData.length());
 delay(500);
  ViewSerialResponse();
  Serial1.print("\n\n");
 delay(500);
 ViewSerialResponse();
  Serial1.print(tmData);
 delay(500);
 ViewSerialResponse();
 Serial1.println((char)26);
 delay(10000); 
 Serial1.println();
 ViewSerialResponse();
 Serial1.println("AT+CIPCLOSE");
 delay(100);
 ViewSerialResponse();
}
void ViewSerialResponse()
{
 while(Serial1.available()!=0)
   Serial.write(Serial1.read());
}
boolean getRainStatus(){
  
}

