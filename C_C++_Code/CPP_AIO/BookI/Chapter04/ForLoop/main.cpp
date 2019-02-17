#include <iostream>

using namespace std;

int main()
{
    int x = 0;
    int i;

    for (i = 1; i <= 100; i++)
    {
       x += i;
    }

    cout << x << endl;
    return 0;
}
