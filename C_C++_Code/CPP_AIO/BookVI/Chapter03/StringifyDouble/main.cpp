#include <iostream>
#include <sstream>
#include <iomanip>
#include <limits>

using namespace std;

template<typename T> inline string stringify(const T& input)
{
    ostringstream output;
    output << input;
    return output.str();
}

template <> inline string stringify<double> (const double& input)
{
    ostringstream output;
    const int sigdigits = numeric_limits<double>::digits10;
    output << setprecision(sigdigits) << input;
    return output.str();
}

int main()
{
    cout << stringify<int>(42) << endl;
    cout << stringify<double>(45.6789012345) << endl;
    return 0;
}
