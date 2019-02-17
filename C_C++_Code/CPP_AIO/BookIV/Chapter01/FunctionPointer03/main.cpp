#include <iostream>
#include <string>

using namespace std;

class Gobstopper
{
public:
    static string MyClassName() {
        return "Gobstopper!";
    }
    int WhichGobstopper;
    int Chew(string name) {
        cout << WhichGobstopper << endl;
        cout << name << endl;
        return WhichGobstopper;
    }
};

int main()
{
    typedef string (*StaticMember)();
    StaticMember staticfunc = &Gobstopper::MyClassName;
    cout << staticfunc() << endl;
}
