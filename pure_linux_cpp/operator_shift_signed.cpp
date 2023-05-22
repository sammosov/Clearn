//https://learn.microsoft.com/ru-ru/cpp/cpp/left-shift-and-right-shift-operators-input-and-output?view=msvc-170
#include <iostream>
#include <bitset>

using namespace std;

int main()
{
    short short1 = 16384;
    bitset<16> bitset1(short1);
    cout << bitset1 << endl;

    short short2 = short1 << 1;
    bitset<16> bitset2(short2);
    cout << bitset2 << endl;

    short short3 = short1 << 14;
    bitset<16> bitset3(short3);
    cout << bitset3 << endl;

}