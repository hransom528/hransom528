#include <iostream>

using namespace std;

int main()
{
    int Numbers[100];

    for (int i=0; i<100; i++)
    {
        Numbers[i] = i * 10;
    }

    int *cur;
    cur = Numbers;

    cout << *cur << endl;
    cur++;
    cout << *cur << endl;
    cur++;
    cout << *cur << endl;
    cur += 3;
    cout << *cur << endl;
    cur--;
    cout << *cur << endl;

    return 0;
}
