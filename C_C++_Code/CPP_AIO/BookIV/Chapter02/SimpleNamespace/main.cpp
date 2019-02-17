#include <iostream>

using namespace std;

namespace Menagerie
{
    class Oxen {
    public:
        int Weight;
        int NumberOfTeeth;
    };
    class Cattle {
    public:
        int Weight;
        int NumberOfChildren;
    };
}

int main()
{
    Menagerie::Cattle bessie;
    bessie.Weight = 643;
    cout << bessie.Weight << endl;
    return 0;
}
