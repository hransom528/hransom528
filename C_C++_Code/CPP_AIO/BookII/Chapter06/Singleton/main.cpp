#include <iostream>

using namespace std;

class Planet {
private:
    static Planet *inst;
    Planet() {}
    ~Planet() {}
public:
    static Planet *GetInstance();
};
Planet *Planet::inst = 0;
Planet *Planet::GetInstance() {
    if (inst == 0) {
        inst = new Planet();
    }
    return inst;
}

int main()
{
    // This line produces an error.
    //Planet *MyPlanet = new Planet();

    // Use this line to create an instance of Planet.
    Planet *MyPlanet = Planet::GetInstance();

    // You can't delete this instance either.
    //delete MyPlanet;
}
