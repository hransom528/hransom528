#include <iostream>
#include <sstream>

using namespace std;

template<typename T> inline string stringify(const T& input)
{
    ostringstream output;
    output << input;
    return output.str();
}

int main()
{
    // This call works as expected.
    cout << stringify<int>(42) << endl;

    // This call truncates.
    cout << stringify<double>(45.6789012345) << endl;

    return 0;
}
