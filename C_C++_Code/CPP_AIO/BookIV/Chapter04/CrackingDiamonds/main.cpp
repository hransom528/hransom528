#include <iostream>
using namespace std;

class Rock {
public:
    int Weight;
};
class Diamond : public Rock {
public:
    void SetDiamondWeight(int newweight) {
        Weight = newweight;
    }
    int GetDiamondWeight() {
        return Weight;
    }
};
class Jade : public Rock {
public:
    void SetJadeWeight(int newweight) {
        Weight = newweight;
    }
    int GetJadeWeight() {
        return Weight;
    }
};
class MeltedMess : public Diamond, public Jade {
};
int main(int argc, char *argv[])
{
    MeltedMess mymess;
    mymess.SetDiamondWeight(10);
    mymess.SetJadeWeight(20);
    cout << mymess.GetDiamondWeight() << endl;
    cout << mymess.GetJadeWeight() << endl;
    return 0;
}
