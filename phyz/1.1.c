#include <stdio.h>

int main(void)
{
    int firstWeight = 5;
    int secondweight = 10;

    // firstWeight came before second and we need to calculate rope tension.

    int ropeTension = firstWeight + secondweight;

    printf("The total rope tension is: %d \n", ropeTension);
    printf("The rope tension between weights is: %d", secondweight); 

}