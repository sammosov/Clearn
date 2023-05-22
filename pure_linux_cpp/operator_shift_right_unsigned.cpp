#include <iostream>
#include <bitset>

using namespace std;

int main()
{
    unsigned short short1 = 1024; 
    bitset<16> bitset1{short1};
    cout << bitset1 << endl;

    unsigned short short2 = short1 >> 1;
    bitset<16> bitset2{short2};
    cout << bitset2 << endl;

    unsigned short short3 = short1 >> 10; 
    bitset<16> bitset3{short3};
    cout << short3 << endl;

    unsigned short short4 = short1 >> 11;
    bitset<16> bitset4{short4};
    cout << short4 << endl;

}