#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

void ProcessVector(vector<int>& vect, int Exclude)
{
    for_each(vect.begin(), vect.end(),
             [Exclude](int x)
             {
                 if ((int)x != Exclude)
                    cout << x << endl;
             });
}

int main()
{
    vector<int> MyVector;
    MyVector.push_back(1);
    MyVector.push_back(2);
    MyVector.push_back(3);
    MyVector.push_back(4);

    ProcessVector(MyVector, 3);
}
