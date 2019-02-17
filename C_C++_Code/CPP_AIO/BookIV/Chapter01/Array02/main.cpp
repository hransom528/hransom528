#include <iostream>

using namespace std;

// This declaration won't work.
extern int MyNumbers[];

// This declaration does.
//extern int MyNumbers[10];
int main(int argc, char *argv[])
{
    cout << sizeof(MyNumbers) << endl;
    return 0;
}
