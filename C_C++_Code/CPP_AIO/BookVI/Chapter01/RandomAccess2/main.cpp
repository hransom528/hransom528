#include <iostream>
#include <vector>

using namespace std;

template <class RandomAccessIterator>
float AddIt(RandomAccessIterator begin, RandomAccessIterator end)
{
    float Sum = 0;

    RandomAccessIterator Index;

    // Make sure that the values are in the correct order.
    if (begin > end)
    {
        RandomAccessIterator temp;
        temp = begin;
        begin = end;
        end = temp;
    }

    for (Index = begin; Index != end; Index++)
        Sum += *Index;

    return Sum;
}

int main()
{
    vector<float> Numbers;

    Numbers.push_back(1.0);
    Numbers.push_back(2.5);
    Numbers.push_back(3.75);
    Numbers.push_back(1.26);
    Numbers.push_back(9.101);
    Numbers.push_back(11.3);
    Numbers.push_back(1.52);

    // Sum the individual members.
    float Sum;
    Sum = AddIt(Numbers.begin(), Numbers.end());
    cout << Sum << endl;

    Sum = AddIt(Numbers.end(), Numbers.begin());
    cout << Sum << endl;

    // Sum a range.
    vector<float>::iterator Iter = Numbers.begin();
    Iter += 5;
    Sum = AddIt(Iter, Numbers.end());
    cout << Sum << endl;

    return 0;
}
