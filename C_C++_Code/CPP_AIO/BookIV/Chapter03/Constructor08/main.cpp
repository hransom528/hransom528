#include <iostream>

using namespace std;

class Copyable
{
protected:
    static int NextAvailableID;
    int UniqueID;
public:
    int SomeNumber;
    int GetID() { return UniqueID; }
    Copyable();
    Copyable(int x);
    Copyable(const Copyable& source);
};

Copyable::Copyable()
{
    UniqueID = NextAvailableID;
    NextAvailableID++;
}

Copyable::Copyable(int x)
{
    UniqueID = NextAvailableID;
    NextAvailableID++;
    SomeNumber = x;
}

Copyable::Copyable(const Copyable& source)
{
    UniqueID = NextAvailableID;
    NextAvailableID++;
    SomeNumber = source.SomeNumber;
}

int Copyable::NextAvailableID;

int main()
{
    Copyable take1 = 100;
    Copyable take2;
    take2.SomeNumber = 200;
    Copyable take3 = take1;

    cout << take1.GetID() << " "
         << take1.SomeNumber << endl;
    cout << take2.GetID() << " "
         << take2.SomeNumber << endl;
    cout << take3.GetID() << " "
         << take3.SomeNumber << endl;
    return 0;
}
