#include <iostream>

using namespace std;

class Squirrel
{
private:
    string Name;

public:
    Squirrel(string StartName);
    void WhatIsMyName();
};

Squirrel::Squirrel(string StartName)
{
    cout << "Starting!" << endl;
    Name = StartName;
}

void Squirrel::WhatIsMyName()
{
    cout << "My name is " << Name << endl;
}

int main()
{
    Squirrel *Sam = new Squirrel("Sam");
    Squirrel *Sally = new Squirrel("Sally");

    Sam->WhatIsMyName();
    Sally->WhatIsMyName();

    delete Sam;
    delete Sally;

    return 0;
}
