#include <iostream>
#include <typeinfo>

using namespace std;

string operator"" _s(const char * str, unsigned len)
{
  return string{str, len};
}

int main()
{
    basic_string<char> StdString = "This is a standard string.";
    auto AutoString = "This is an auto string."_s;

    // Remove comment when your compiler supports C++ 14.
    //auto UDLString = "This is a UDL string."s;

    cout << StdString << endl << typeid(StdString).name() << endl;
    cout << AutoString << endl << typeid(AutoString).name() << endl;

    // Remove comment when your compiler supports C++ 14.
    //cout << UDLString << endl << typeid(UDLString).name() << endl;

    return 0;
}
