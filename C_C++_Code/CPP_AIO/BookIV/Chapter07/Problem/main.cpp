#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

class MyFunctor
{
public:
    void operator()(int x)
    {
        cout << x << endl;
    }
};

void ProcessVector(vector<int>& vect)
{
    MyFunctor Func;
    for_each(vect.begin(), vect.end(), Func);
}

int main()
{
    vector<int> MyVector;
    MyVector.push_back(1);
    MyVector.push_back(2);
    MyVector.push_back(3);
    MyVector.push_back(4);

    ProcessVector(MyVector);
}
