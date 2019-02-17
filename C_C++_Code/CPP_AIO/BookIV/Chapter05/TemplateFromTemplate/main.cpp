#include <iostream>

using namespace std;

template <typename T>
class Base
{
public:
    T a;
};

template <typename T>
class Derived : public Base<T>
{
public:
    T b;
};

void TestInt(Base<int> *inst)
{
    cout << inst->a << endl;
}

void TestDouble(Base<double> *inst)
{
    cout << inst->a << endl;
}

int main()
{
    Base<int> base_int;
    Base<double> base_double;

    Derived<int> derived_int;
    Derived<double> derived_double;

    TestInt(&base_int);
    TestInt(&derived_int);

    TestDouble(&base_double);
    TestDouble(&derived_double);
    //TestDouble(&derived_int);

    return 0;
}
