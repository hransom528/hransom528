#include <iostream>
#include <cstdlib>

using namespace std;

int SeatsPerCar()
{
    return 4;
}

int CountCarSeats()
{
    return 10 * SeatsPerCar();
}

int CountStuff()
{
    return CountCarSeats() + 25;
}

int main()
{
    cout << CountStuff() << endl;
    // Remove the following comment to see the code
    // execute in the debugger.
    //system("PAUSE");
    return 0;
}
