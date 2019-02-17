#include <iostream>

using namespace std;

void Inner()
{
    throw string("Error!");
}

void Outer()
{
    try
    {
        Inner();
    }
    catch (string excep)
    {
        cout << "Outer caught an exception: ";
        cout << excep << endl;
        throw;
    }
}

int main()
{
    try
    {
        Outer();
    }
    catch (string excep)
    {
        cout << "main caught an exception: ";
        cout << excep << endl;
    }

    return 0;
}
