#include <iostream>

using namespace std;

class MyName
{
public:
    string First;
    MyName(string TheFirst) : First(TheFirst) {}
};

void WriteName(MyName name)
{
    cout << "Hi I am " << name.First << endl;
}

int main()
{
    // This line doesn't work. Uncomment the line to see
    // the error.
    //WriteName("George");

    // This line does work.
    WriteName(string("George"));
}
