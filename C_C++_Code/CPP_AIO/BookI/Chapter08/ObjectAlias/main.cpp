#include <iostream>

using namespace std;

int main()
{
    string OriginalString = "Hello";
    const string &StringCopy(OriginalString);

    OriginalString = "Goodbye";

    cout << OriginalString << endl;
    cout << StringCopy << endl;

    return 0;
}
