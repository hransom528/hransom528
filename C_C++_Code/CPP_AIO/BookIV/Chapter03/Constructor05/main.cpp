#include <iostream>
#include <string>

using namespace std;

void WriteMe(string str)
{
    cout << "Here I am: " << str << endl;
}

int main()
{
    WriteMe(string("Sam"));
    return 0;
}
