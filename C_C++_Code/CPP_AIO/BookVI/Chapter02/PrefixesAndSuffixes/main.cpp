#include <iostream>
#include <typeinfo>
#include <cxxabi.h>

using namespace std;
using namespace abi;

char* Demangle(const char* Object)
{
    int Status;
    char* RealName;

    RealName = __cxa_demangle(Object, 0, 0, &Status);
    return RealName;
}

int main()
{
    auto Int1 = 23;
    auto Int2 = 23L;
    auto Int3 = 23U;
    auto Int4 = 23u;

    auto String1 = "Hello";
    auto String2 = L"Hello";
    auto String3 = U"Hello";
    auto String4 = u"Hello";

    cout << Int1 << endl << Demangle(typeid(Int1).name()) << endl;
    cout << Int2 << endl << Demangle(typeid(Int2).name()) << endl;
    cout << Int3 << endl << Demangle(typeid(Int3).name()) << endl;
    cout << Int4 << endl << Demangle(typeid(Int4).name()) << endl;

    cout << String1 << endl << Demangle(typeid(String1).name()) << endl;
    cout << String2 << endl << Demangle(typeid(String2).name()) << endl;
    cout << String3 << endl << Demangle(typeid(String3).name()) << endl;
    cout << String4 << endl << Demangle(typeid(String4).name()) << endl;

    return 0;
}
