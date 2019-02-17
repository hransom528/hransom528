#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

void CompareRanges(vector<int>& vect, int values[])
{
    auto Result =
        equal(vect.begin(), vect.end(), values,
              [](int x, int y){return x==y;});

    cout.setf(ios::boolalpha);
    cout << "The values are equal: " << Result << endl;
}

int main()
{
    vector<int> MyVector;
    MyVector.push_back(1);
    MyVector.push_back(2);
    MyVector.push_back(3);
    MyVector.push_back(4);

    int MyInts[] = {1, 2, 3, 4};

    CompareRanges(MyVector, MyInts);
}
