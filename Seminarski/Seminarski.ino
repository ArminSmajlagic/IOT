#include <Arduino.h>
#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <WiFiClient.h>

const int size = 5;
int* temperaturaRaste = new int[size];
    
bool stanjeKlime = false;

int trenutnaTemperatura = 0;
int kontrolnaTemperatura = 0;

void pripremiTemperaturuRasta(){
  for(int i=0;i<size;i++){
    temperaturaRaste[i]=trenutnaTemperatura+i;
  }
}

void upaliKlimu(){
  stanjeKlime=true;

  promjeniTemperaturu();
}

void ugasiKlimu(){
   stanjeKlime=false;

   pripremiTemperaturuRasta();
   
   for(int i=0;i<size;i++){
    trenutnaTemperatura = temperaturaRaste[i];
    provjeriTemperaturu();
    postTemperatura(trenutnaTemperatura);
    delay(5000);
  }
}


void promjeniTemperaturu(){
    getKontrolnaTemperatura();

    if(trenutnaTemperatura!=kontrolnaTemperatura){
        int razlika = 0;
        int rast = 0;
        
        if(trenutnaTemperatura<kontrolnaTemperatura){
          razlika=kontrolnaTemperatura-trenutnaTemperatura;
          rast = 1;
        }else{
          razlika=trenutnaTemperatura-kontrolnaTemperatura;
        }
        
        for(int i=0;i<razlika;i++){
          
          if(rast == 1){
            trenutnaTemperatura++;
          }else{
            trenutnaTemperatura--;
          }
          provjeriTemperaturu();
          postTemperatura(trenutnaTemperatura);
          
          delay(5000);
        }
    }
}

void provjeriTemperaturu(){
  Serial.println("Trenutna temperatura :"+trenutnaTemperatura);
  if(trenutnaTemperatura>=30){
    digitalWrite(2,LOW);
  }else{
    digitalWrite(2 , HIGH);     
  }
}



void postTemperatura(int temperatura){
  if ((WiFi.status() == WL_CONNECTED)) {

    WiFiClient client;
    HTTPClient http;

    Serial.print("[HTTP] begin...\n");
    // configure traged server and url
    http.begin(client, "http://iot.p2098.app.fit.ba/Nodemcu"); //HTTP
    http.addHeader("Content-Type", "application/json");

    Serial.print("[HTTP] POST...\n");
    // start connection and send HTTP header and body
    
    String myString = String(temperatura);
    Serial.println(myString);
    int httpCode = http.POST("\""+myString+"\"");

    // httpCode will be negative on error
    if (httpCode > 0) {
      // HTTP header has been send and Server response header has been handled
      Serial.printf("[HTTP] POST... code: %d\n", httpCode);

      // file found at server
      if (httpCode == HTTP_CODE_OK) {
        const String& payload = http.getString();
        Serial.println("received payload:\n<<");
        Serial.println(payload);
        Serial.println(">>");
      }
    } else {
      Serial.printf("[HTTP] POST... failed, error: %s\n", http.errorToString(httpCode).c_str());
    }

    http.end();
  }
}

void getKlimaStanje(){
 // wait for WiFi connection
  if ((WiFi.status() == WL_CONNECTED)) {

    WiFiClient client;
    HTTPClient http;

    Serial.print("[HTTP] begin...\n");
    if (http.begin(client, "http://iot.p2098.app.fit.ba/Nodemcu/Klima")) {  // HTTP


      Serial.print("[HTTP] GET...\n");
      // start connection and send HTTP header
      int httpCode = http.GET();

      // httpCode will be negative on error
      if (httpCode > 0) {
        // HTTP header has been send and Server response header has been handled
        Serial.printf("[HTTP] GET... code: %d\n", httpCode);

        // file found at server
        if (httpCode == HTTP_CODE_OK || httpCode == HTTP_CODE_MOVED_PERMANENTLY) {
          String payload = http.getString();
          Serial.println("Stanje klime :"+payload);
          if(payload=="true" && stanjeKlime!=true){
            upaliKlimu();
          }else if(payload=="false" && stanjeKlime!=false){
            ugasiKlimu();
          }else if(payload=="true" && stanjeKlime==true){
            promjeniTemperaturu();
          }
        }
      } else {
        Serial.printf("[HTTP] GET... failed, error: %s\n", http.errorToString(httpCode).c_str());
      }

      http.end();
    } else {
      Serial.printf("[HTTP} Unable to connect\n");
    }
  }
}

void getKontrolnaTemperatura(){
 // wait for WiFi connection
  if ((WiFi.status() == WL_CONNECTED)) {

    WiFiClient client;
    HTTPClient http;

    Serial.print("[HTTP] begin...\n");
    if (http.begin(client, "http://iot.p2098.app.fit.ba/Nodemcu/Temperatura/Promjena")) {  // HTTP


      Serial.print("[HTTP] GET...\n");
      // start connection and send HTTP header
      int httpCode = http.GET();

      // httpCode will be negative on error
      if (httpCode > 0) {
        // HTTP header has been send and Server response header has been handled
        Serial.printf("[HTTP] GET... code: %d\n", httpCode);

        // file found at server
        if (httpCode == HTTP_CODE_OK || httpCode == HTTP_CODE_MOVED_PERMANENTLY) {
          String payload = http.getString();
          Serial.println("Kontrolna temperatura : "+payload);
          kontrolnaTemperatura = payload.toInt();
        }
      } else {
        Serial.printf("[HTTP] GET... failed, error: %s\n", http.errorToString(httpCode).c_str());
      }

      http.end();
    } else {
      Serial.printf("[HTTP} Unable to connect\n");
    }
  }
}

void getTemperaturaProstorije(){
 // wait for WiFi connection
  if ((WiFi.status() == WL_CONNECTED)) {

    WiFiClient client;
    HTTPClient http;

    Serial.print("[HTTP] begin...\n");
    if (http.begin(client, "http://iot.p2098.app.fit.ba/Nodemcu/Temperatura")) {  // HTTP


      Serial.print("[HTTP] GET...\n");
      // start connection and send HTTP header
      int httpCode = http.GET();

      // httpCode will be negative on error
      if (httpCode > 0) {
        // HTTP header has been send and Server response header has been handled
        Serial.printf("[HTTP] GET... code: %d\n", httpCode);

        // file found at server
        if (httpCode == HTTP_CODE_OK || httpCode == HTTP_CODE_MOVED_PERMANENTLY) {
          String payload = http.getString();
          Serial.println("Temperatura prostorije : "+payload);
          trenutnaTemperatura = payload.toInt();
        }
      } else {
        Serial.printf("[HTTP] GET... failed, error: %s\n", http.errorToString(httpCode).c_str());
      }

      http.end();
    } else {
      Serial.printf("[HTTP} Unable to connect\n");
    }
  }
}


void setup() {

  pinMode(2,OUTPUT);
  Serial.begin(115200);

  WiFi.begin("MojaTV_Net_331704", "BBLLHMMUHGBBLLHMMUHG");

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected! IP address: ");
  Serial.println(WiFi.localIP());
  
  getTemperaturaProstorije();
  provjeriTemperaturu();
}

void loop() {
  getKlimaStanje();
  delay(5000);
}
