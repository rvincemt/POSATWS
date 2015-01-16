/* TODO: Implement these.
#include <SD.h>               
#include <Dhcp.h>
#include <Dns.h>
#include <Ethernet.h>
#include <EthernetClient.h>
#include <EthernetServer.h>
#include <EthernetUdp.h>
#include <util.h>
*/
#include <LiquidCrystal.h>


unsigned char buffer[64]; 
int count=0;     
String response="";
int incomingByte = 0;
void setup()
{
  
 Serial1.begin(19200);                 
 Serial.begin(19200);             

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
 pinMode(9, OUTPUT); 
 digitalWrite(9,LOW);
 delay(1000);
 digitalWrite(9,HIGH);
 delay(2000);
 digitalWrite(9,LOW);
 delay(3000);
}
void powerDown()
{
 pinMode(9, OUTPUT); 
 digitalWrite(9,LOW);
 delay(1000);
 digitalWrite(9,HIGH);
 delay(2000);
 digitalWrite(9,LOW);
 delay(3000);
}

void SendTextMessage()
{
 Serial1.print("AT+CMGF=1\r");    
 delay(100);
 Serial1.println("AT + CMGS = \"+639062000323\"");
 delay(100);
 Serial1.println("A test message!");
 delay(100);
 Serial1.println((char)26);
 delay(100);
 Serial1.println();
}

void getSensorData(){
  //TODO: Sensor Data algorithm
}

