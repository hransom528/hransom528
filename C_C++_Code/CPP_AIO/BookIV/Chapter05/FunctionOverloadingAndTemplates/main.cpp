#include <iostream>

using namespace std;

int AbsoluteValue(int x)
{
    if (x >= 0)
        return x;
    else
        return -x;
}

float AbsoluteValue(float x)
{
    if (x >= 0)
        return x;
    else
        return -x;
}

// Uncomment this code to see the template version.
//template <typename T> T AbsoluteValue(T x)
//{
//    if (x >= 0)
//        return x;
//    else
//        return -x;
//}

int main()
{
    // This code errors out.
    cout << AbsoluteValue(10.5) << endl;

    // Uncomment this code to see the template version.
//    cout << AbsoluteValue<int>(10) << endl;
//    cout << AbsoluteValue<float>(10.5) << endl;
    return 0;
}
