#include <iostream>

using namespace std;

#ifdef UNIVAC
const int total = 200;
const string compname = "UNIVAC";
#elif defined(HAL2000)
const int total = 300;
const string compname = "HAL2000";
#else
const int total = 400;
const string compname = "My Computer";
#endif
// This is outdated, but you might
// see it on occasion. Don’t write
// code yourself that does this!
#define oldmax(x, y) ((x)>(y)?(x):(y))
#define MYSPECIALNUMBER 42

int main()
{
    cout << "Welcome to " << compname << endl;
    cout << "Total is:" << endl;
    cout << total << endl << endl;

    // Try out the outdating things.
    cout << "*** max ***" << endl;
    cout << oldmax(5,10) << endl;
    cout << oldmax(20,15) << endl;
    cout << MYSPECIALNUMBER << endl << endl;

    // Here are some standard
    // predefined macros.
    cout << "*** Predefined Macros ***" << endl;
    cout << "This is file " << __FILE__ << endl;
    cout << "This is line " << __LINE__ << endl;
    cout << "Compiled on " << __DATE__ << endl;
    cout << "Compiled at " << __TIME__ << endl << endl;

    // Here’s how some people use #define,
    // to specify a "debug" version or
    // "release" version.
    cout << "*** total ***" << endl;
    int i;
    int j = 0;
    for (i = 0; i<total; i++)
    {
        j = j + i;
    }

#ifdef DEBUG
    cout << "The value of j is " << j << endl;
#else
    cout << j << endl;
#endif

    return 0;
}
