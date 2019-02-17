#include <iostream>

using namespace std;

int main()
{
    auto Cooked = "(Hello\r\nThere)";
    auto Raw = R"(Hello\r\nThere)";

    cout << Cooked << endl;
    cout << Raw << endl;
}
