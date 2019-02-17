#include <iostream>

using namespace std;

namespace Work
{
    int FavoriteNumber;

    class Info
    {
    public:
        string CompanyName;
        string Position;
    };

    void DoStuff()
    {
        cout << "Doing some work!" << endl;
    }
}

namespace Play
{
    int FavoriteNumber;

    class Info
    {
    public:
        string FullName;
        string Hobby;
    };

    void DoStuff()
    {
        cout << "Having fun!" << endl;
    }
}

int main()
{
    // Work stuff
    Work::FavoriteNumber = 7;
    Work::Info WorkInformation;
    WorkInformation.CompanyName = "Spaceley Sprockets";
    WorkInformation.Position = "Worker";
    Work::DoStuff();

    // Play stuff
    Play::FavoriteNumber = 13;
    Play::Info PlayInformation;
    PlayInformation.FullName = "George Jetson";
    PlayInformation.Hobby = "Playing with the dog";
    Play::DoStuff();

    return 0;
}
