#include <iostream>
#include <bitset>

using namespace std;

int main()
{
    short neg1 = -16;
    bitset<16> bn1(neg1);
    cout << bn1 << endl;

    short neg2 = neg1 >> 1;
    bitset<16> bn2(neg2);
    cout << bn2 << endl;

    short neg3 = neg1 >> 2;
    bitset<16> bn3(neg3);
    cout << bn3 << endl;

    short neg4 = neg1 >> 4; 
    bitset<16> bn4(neg4);
    cout << bn4 << endl;

    short neg5 = neg1 >> 5;
    bitset<16> bn5(neg5);
    cout << bn5 << endl;
}