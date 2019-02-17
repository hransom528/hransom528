#include <iostream>

using namespace std;

const int MyArraySize = 10;

void Crunch(int myarray[], int size)
{
    for (int i=0; i<size; i++)
    {
        cout << myarray[i] << endl;
    }
}

int main()
{
    int BigArray[MyArraySize];

    for (int i=0; i<MyArraySize; i++)
    {
        BigArray[i] = i * 2;
    }

    Crunch(BigArray, MyArraySize);

    return 0;
}
