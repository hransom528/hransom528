#include <iostream>

using namespace std;

int main()
{
    int x,y;

    for (x = 1; x <= 10; x++)
    {
        cout << "Products of " << x <<endl;
        for (y = 1; y <= 10; y++)
        {
            cout << x * y << endl;
        }
        cout << endl;
    }

    return 0;
}
