#include <iostream>

using namespace std;

class MusicInfo
{
public:
    int PhoneNumber;
    MusicInfo(int Phone) : PhoneNumber(Phone) {}
};

class MySharona : public MusicInfo
{
protected:
    int OneHitWonders;
    int NumberRecordings;
public:
    MySharona(int Records, int Phone=8675309) :
         MusicInfo(Phone), OneHitWonders(1),
        NumberRecordings(Records) {}
};

int main()
{
    MySharona CD(20, 5551212);
    MySharona OldCD(30);
    cout << CD.PhoneNumber << endl;
    cout << OldCD.PhoneNumber << endl;
}
