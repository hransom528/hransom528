#include <iostream>

using namespace std;

namespace A
{
    int X;
}

namespace B
{
    using A::X;
}

int main()
{
    A::X = 2;
    cout << B::X << endl;
    return 0;
}
