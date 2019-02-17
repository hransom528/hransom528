#include <iostream>
#include <algorithm>
#include <vector>
#include <stdexcept>

using namespace std;

void ProcessVector(vector<int>& vect)
{
    sort(vect.begin(), vect.end(),
         [](int S1, int S2) throw(out_of_range)
         {
                 if (S1 > 100 || S2 > 100)
                    throw new out_of_range("Value over 100");

             return S1 < S2;
         });

    for_each(vect.begin(), vect.end(),
             [](int x) throw() {cout << x << endl;});
}

int main()
{
    vector<int> MyVector;
    MyVector.push_back(11);
    MyVector.push_back(2);
    MyVector.push_back(33);
    MyVector.push_back(4);

    // Remove comment to see the exception.
    //MyVector.push_back(101);

    ProcessVector(MyVector);
}
