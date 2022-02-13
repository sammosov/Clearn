#include <stdio.h>

int main(void)
{
    int towPower = 1800;
    int waterTowRwsistance = 600;
    int waterBarge1Rsistance = 600;
    int waterBarge2Rsistance = 400;
    int waterBarge3Rsistance = 200;
    int ropeResistance = 200;
    int ropeCount1=0;

    int waterTotalBargeResistance = waterBarge1Rsistance + waterBarge2Rsistance + waterBarge3Rsistance;
    
    int toeExactPower = towPower - waterTowRwsistance;

    while(toeExactPower!=ropeResistance*ropeCount1)
    {
        if(toeExactPower==ropeResistance*ropeCount1) break;
        ropeCount1++;
        //printf("%d",ropeCount1);

        
    }; 

     printf("\n%d",ropeCount1);


}