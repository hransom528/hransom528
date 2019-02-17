#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

void StandardSort(vector<int>& vect)
{
    sort(vect.begin(), vect.end());
    cout << "Using the Standard Sort" << endl;
    for_each(vect.begin(), vect.end(), [](int x){cout << x << endl;});
}

void ProcessVector(vector<int>& vect)
{
    sort(vect.begin(), vect.end(), [](int S1, int S2){return S1 > S2;});
    cout << "Using a Custom Sort" << endl;
    for_each(vect.begin(), vect.end(), [](int x){cout << x << endl;});
}

int main()
{
    vector<int> MyVector;
    MyVector.push_back(11);
    MyVector.push_back(2);
    MyVector.push_back(33);
    MyVector.push_back(4);

    StandardSort(MyVector);
    ProcessVector(MyVector);
}
