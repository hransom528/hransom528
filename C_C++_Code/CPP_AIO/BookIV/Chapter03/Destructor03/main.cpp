#include <iostream>

using namespace std;

class DeleteMe
{
public:
    int Number;
    virtual ~DeleteMe();
};

class Derived : public DeleteMe
{
public:
    virtual ~Derived();
};

DeleteMe::~DeleteMe()
{
    cout << "DeleteMe::~DeleteMe()" << endl;
}

Derived::~Derived()
{
    cout << "Derived::~Derived()" << endl;
}

void ProcessAndDelete(DeleteMe *inst)
{
    cout << inst->Number << endl;
    delete inst;
}

int main()
{
    DeleteMe *MyObject = new(Derived);
    MyObject->Number = 10;
    ProcessAndDelete(MyObject);
    return 0;
}
