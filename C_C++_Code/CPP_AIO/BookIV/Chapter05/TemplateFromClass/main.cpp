#include <iostream>

using namespace std;

class SuperMath
{
public:
    int IQ;
};

template <typename T>
class SuperNumber : public SuperMath
{
public:
    T value;

    T &AddTo(T another)
    {
        value += another;
        return value;
    }

    T &SubtractFrom(T another)
    {
        value -= another;
        return value;
    }
};

void IncreaseIQ(SuperMath &inst)
{
    inst.IQ++;
}

int main()
{
    SuperNumber<int> First;
    First.value = 10;
    First.IQ = 206;
    cout << First.AddTo(20) << endl;

    SuperNumber<float> Second;
    Second.value = 20.5;
    Second.IQ = 201;
    cout << Second.SubtractFrom(1.3) << endl;

    IncreaseIQ(First);
    IncreaseIQ(Second);
    cout << First.IQ << endl;
    cout << Second.IQ << endl;

    return 0;
}
