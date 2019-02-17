#include <iostream>

using namespace std;

int main()
{
    int x,y,z;

    for (x = 1; x <= 3; x++)
    {
        for (y = 1; y < 3; y++)
        {
            if (y == 2)
               break;
            for (z = 1; z < 3; z++)
            {
                cout << x << " " << y;
                cout << " " << z << endl;
            }
        }
    }

    return 0;
}
