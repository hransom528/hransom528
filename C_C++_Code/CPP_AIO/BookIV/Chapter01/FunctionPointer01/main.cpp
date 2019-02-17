#include <iostream>

using namespace std;

typedef int(*FunctionPtr)(int);

int TheSecretNumber(int x)
{
    return x + 1;
}

int main()
{
    typedef int (*FunctionPtr)(int);
    int MyPasscode = 20;
    FunctionPtr address = &TheSecretNumber;
    cout << address(MyPasscode) << endl;
}
