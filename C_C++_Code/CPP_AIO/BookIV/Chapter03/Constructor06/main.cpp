#include <iostream>

using namespace std;

class MyNumber
{
public:
    int First;
    MyNumber(int TheFirst) : First(TheFirst) {}
};

void WriteNumber(MyNumber num)
{
    cout << num.First << endl;
}

int main()
{
    MyNumber prime = 17;
    WriteNumber(prime);
    WriteNumber(MyNumber(23));
    WriteNumber(29);
}
