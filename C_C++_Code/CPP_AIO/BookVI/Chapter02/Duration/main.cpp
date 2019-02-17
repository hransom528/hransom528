#include <iostream>
#include <chrono>

using namespace std;

chrono::duration<unsigned long long> operator"" _m(
   unsigned long long Value)
{
    return chrono::duration<int, ratio<60>>(Value);
}

int main()
{
    typedef chrono::duration<double, ratio<1, 5>> fifths;

    // Define an interval of 20 minutes.
    chrono::duration<int, ratio<60>>StdTime(20);
    auto AutoTime(20_m);

    // Remove comment when your compiler supports C++ 14.
    //auto UDLTime(20min);

    // Output the time in seconds.
    cout << chrono::duration_cast<chrono::seconds>(StdTime).count()
        << endl;
    cout << chrono::duration_cast<chrono::seconds>(AutoTime).count()
        << endl;

    // Remove comment when your compiler supports C++ 14.
    //cout << chrono::duration_cast<chrono::seconds>(UDLTime).count()
    //    << endl;

    return 0;
}
