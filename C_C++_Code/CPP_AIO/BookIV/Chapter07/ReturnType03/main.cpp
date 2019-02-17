#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

void ProcessVector(vector<int>& vect)
{
    vector<bool> Result;
    Result.resize(vect.size());

    auto Transformer = [](int x){return x > 3;};
    transform(vect.begin(), vect.end(), Result.begin(),
              Transformer);

    cout.setf(ios::boolalpha);
    auto DoPrint = [](bool x){cout << x << endl;};
    for_each(Result.begin(), Result.end(),
             DoPrint);
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
