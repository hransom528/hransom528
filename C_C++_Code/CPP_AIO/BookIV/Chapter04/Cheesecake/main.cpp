#include <iostream>

using namespace std;

class Cheesecake {
public:
    enum Flavor {
        ChocolateSuicide, SquishyStrawberry, BrokenBanana,
        PrettyPlainVanilla, CoolLuah, BizarrePurple
    };
    Flavor SelectedFlavor;
    int AmountLeft;
    void Eat() {
        AmountLeft = 0;
    }
};


int main()
{
    Cheesecake yum;
    yum.SelectedFlavor = Cheesecake::SquishyStrawberry;
    yum.AmountLeft = 100;
    yum.Eat();
    cout << yum.AmountLeft << endl;
    return 0;
}
