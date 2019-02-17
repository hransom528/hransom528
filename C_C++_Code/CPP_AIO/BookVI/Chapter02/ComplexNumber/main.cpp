#include <iostream>
#include <complex>

using namespace std;

complex<long double> operator"" _i(long double Value)
{
    return complex<double>(0, Value);
}

int main()
{
    complex<double> StdComplex(0, 3.14);
    auto AutoComplex = 3.14_i;

    // Remove comment when your compiler supports C++ 14.
    //auto UDLComplex = 3.14i;

    cout << StdComplex.real() << " " << StdComplex.imag() << endl;
    cout << AutoComplex.real() << " " << AutoComplex.imag() << endl;

    // Remove comment when your compiler supports C++ 14.
    //cout << UDLComplex.real() << " " << UDLComplex.imag() << endl;

    return 0;
}
