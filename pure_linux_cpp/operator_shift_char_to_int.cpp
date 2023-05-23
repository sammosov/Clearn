#include <iostream>
#include <typeinfo>

using namespace std;

int main()
{
    char char1 = 'a';

    auto promoted1 = char1 << 1;
    cout << typeid(promoted1).name() << endl;    

    auto promoted2  = char1 << 10;
    cout << typeid(promoted2).name() << endl;
}