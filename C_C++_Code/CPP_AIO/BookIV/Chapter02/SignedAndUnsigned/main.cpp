#include <iostream>

using namespace std;

int main()
{
    short int hoopla;
    hoopla = 0x0000;
    cout << "0x0000: " << hoopla << endl;
    hoopla = 0x0001;
    cout << "0x0001: " << hoopla << endl;
    hoopla = 0x7fff;
    cout << "0x7fff: " << hoopla << endl;
    hoopla = 0x8000;
    cout << "0x8000: " << hoopla << endl;
    hoopla = 0xffff;
    cout << "0xffff: " << hoopla << endl;
}
