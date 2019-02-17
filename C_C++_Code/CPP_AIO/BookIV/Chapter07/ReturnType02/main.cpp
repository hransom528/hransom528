#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

void ProcessVector(vector<int>& vect)
{
    vector<bool> Result;
    Result.resize(vect.size());

    transform(vect.begin(), vect.end(), Result.begin(),
              [](int x)->bool{return x > 3;});

    cout.setf(ios::boolalpha);
    for_each(Result.begin(), Result.end(),
             [](bool x){cout << x << endl;});
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
