#include <iostream>

using namespace std;

int main()
{
    int GrilledShrimp[5];

    for (int i=0; i<5; i++)
    {
        GrilledShrimp[i] = i * 2;
        cout << GrilledShrimp[i] << endl;
    }

    return 0;
}
