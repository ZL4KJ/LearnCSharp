#include <wiringPi.h>

// LED Pin - wiringPi pin 0 is BCM_GPIO 17.

#define	LED	17

int main(void)
{
    wiringPiSetupSys();

    pinMode(LED, OUTPUT);

    while (true)
    {
        digitalWrite(LED, HIGH);  // On
        delay(500); // ms
        digitalWrite(LED, LOW);   // Off
        delay(500);
    }
    return 0;