#include <iostream>

using namespace std;

typedef char *PChar;

void MyFunction(PChar &x)
{
    x = new char('B');
}

int main()
{
    char *ptr = new char('A');
    char *copy = ptr;
    MyFunction(ptr);
    cout << "ptr points to " << *ptr << endl;
    cout << "copy points to " << *copy << endl;
}
