#include <iostream>

using namespace std;

int main()
{
    int i;

    for (i=0; i<10; i++)
    {
        cout << i << " ";
        if (i == 5)
        {
            cout << endl;
            continue;
        }
        cout << i * 2 << endl;
    }

    cout << "All Finished!" << endl;

    return 0;
}
