#include <iostream>

using namespace std;

typedef char *PChar;

void AnotherFunction(PChar *x)
{
    *x = new char('C');
}

int main()
{
    char *ptr = new char('A');
    char *copy = ptr;
    AnotherFunction(&ptr);
    cout << "ptr points to " << *ptr << endl;
    cout << "copy points to " << *copy << endl;
}
