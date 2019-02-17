#include <iostream>

using namespace std;

int uggle;

int &ChangeMe()
{
    return uggle;
}

int &DontKnow()
{
    return uggle;
}

int main()
{
    ChangeMe() = 10;
    DontKnow() = 20;
}
