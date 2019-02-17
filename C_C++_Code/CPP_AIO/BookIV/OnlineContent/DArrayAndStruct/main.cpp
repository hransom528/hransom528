#include <iostream>
#include <new>

using namespace std;

struct Employee
{
    string Name;
    int Age;
};

int main()
{
    Employee* DynArray;

    DynArray = new (nothrow) Employee[3];
    DynArray[0].Name = "Harvey";
    DynArray[0].Age = 33;
    DynArray[1].Name = "Sally";
    DynArray[1].Age = 26;
    DynArray[2].Name = "Jeff";
    DynArray[2].Age = 52;

    cout << "Displaying the Array Content" << endl;

    for (int i = 0; i < 3; i++)
    {
        cout << "Name: " << DynArray[i].Name <<
            "\tAge: " << DynArray[i].Age << endl;
    }

    delete[] DynArray;

    return 0;
}
