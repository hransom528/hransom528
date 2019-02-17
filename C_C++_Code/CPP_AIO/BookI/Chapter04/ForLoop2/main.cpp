#include <iostream>

using namespace std;

int main()
{
    double x = 0.0;
    double i;

    for (i = 0.0; i <= 100; i+=0.1)
    {
        x += i;
    }

    cout << x << endl;

    return 0;
}
