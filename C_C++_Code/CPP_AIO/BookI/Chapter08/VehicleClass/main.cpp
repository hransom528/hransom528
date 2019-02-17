#include <iostream>

using namespace std;

class Vehicle
{
public:
    int NumberOfWheels;

    void Drive()
    {
        cout << "Driving, driving, driving..." << endl;
    }
};

class Toyota : public Vehicle
{
public:
    void MeAndMyToyota()
    {
        cout << "Just me and my Toyota!" << endl;
    }
};

int main()
{
    Toyota MyCar;
    MyCar.MeAndMyToyota();
    MyCar.Drive();

    return 0;
}
