#include <iostream>

using namespace std;

int main()
{
    int Number1, Number2;

    cout << "Type the first number: ";
    cin >> Number1;

    cout << "Type the second number: ";
    cin >> Number2;

    cout << "The minimum number is: " << min(Number1, Number2) << endl;
    cout << "The maximum number is: " << max(Number1, Number2) << endl;

    return 0;
}
