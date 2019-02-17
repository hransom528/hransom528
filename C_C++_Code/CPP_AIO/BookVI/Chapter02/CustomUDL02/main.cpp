#include <iostream>

using namespace std;

struct MyType
{
    MyType (double Input):Value(Input){}
    double Value;
};

MyType operator"" _mytype (long double Value)
{
    return MyType(Value);
}

int main()
{
    auto UDLType = 145.6_mytype;

    cout << UDLType.Value << endl;

    return 0;
}
