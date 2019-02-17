#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{
    // Re-seed the random-number generator
    time_t now;
    time(&now);
    srand(now);
    rand();

    // Print out a list of random numbers
    for (int i=0; i<5; i++)
    {
        cout << rand() % 100 << endl;
    }

    return 0;
}
