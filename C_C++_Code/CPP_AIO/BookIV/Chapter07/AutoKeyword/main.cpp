#include <iostream>

using namespace std;

int main()
{
    for (auto i = 0; i < 8; i++)
        cout << i << endl;

    auto Greeting = "Hello";
    cout << Greeting << endl;

    auto LargeNumber = 15;
    LargeNumber += 2147483647;
    cout << LargeNumber << endl;

    return 0;
}
