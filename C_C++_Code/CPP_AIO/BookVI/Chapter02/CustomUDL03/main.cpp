#include <iostream>

using namespace std;

void operator"" _countdown (unsigned long long Value)
{
    for (int i = Value; i >= 0; i--)
        cout << i << endl;
}

int main()
{
    10_countdown;

    return 0;
}
