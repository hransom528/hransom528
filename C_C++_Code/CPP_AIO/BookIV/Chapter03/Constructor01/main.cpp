#include <iostream>

using namespace std;

class Clutter
{
protected:
    string ChildName;
    int Toys;

public:
    Clutter(int count, string name)
    {
        ChildName = name;
        Toys = count;
    }

    Clutter(string name)
    {
        ChildName = name;
        Toys = 0;
    }
};

int main()
{
    Clutter inst1("Jim");
    Clutter inst2(123, "Sally");
}
