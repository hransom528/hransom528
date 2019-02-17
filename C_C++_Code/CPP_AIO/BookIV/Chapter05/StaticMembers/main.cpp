#include <iostream>

using namespace std;

template <typename T>
class Electricity
{
public:
    static T charge;
};

template <typename T>
T Electricity<T>::charge;

int main()
{
    Electricity<int>::charge = 10;
    Electricity<float>::charge = 98.6;
    Electricity<int> inst;
    inst.charge = 22;

    cout << Electricity<int>::charge << endl;
    cout << Electricity<float>::charge << endl;
    cout << inst.charge << endl;

    return 0;
}
