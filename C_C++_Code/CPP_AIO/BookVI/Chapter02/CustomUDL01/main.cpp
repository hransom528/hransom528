#include <iostream>

using namespace std;

constexpr long double operator"" _circ ( long double radius )
{
    return radius*radius*3.141592;
}

int main()
{
    double x = 5.0_circ;

    cout << "The circle's area is: " << x << endl;
    return 0;
}
