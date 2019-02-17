#include <iostream>

using namespace std;

int main()
{
    int i;
    cout.setf(ios_base::showpoint);
    cout.precision(4);
    for (i=1; i<=10; i++) {
        cout << 1.0 / i << endl;
    }
    cout << 2.0 << endl;
    cout << 12.0 << endl;
    cout << 12.5 << endl;
    cout << 123.5 << endl;
    cout << 1234.9 << endl;
    cout << 12348.8 << endl;
    cout << 123411.5 << endl;
    cout << 1234111.5 << endl;
    return 0;
}
