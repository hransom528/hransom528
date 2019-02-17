#include <iostream>

using namespace std;

const int ParkingSpaces = 80;
const string StoreName = "Joe's Food Haven";
const float pi = 3.1415926;

int main()
{
    cout << "Important Message" << endl;
    cout << "Here at " << StoreName << endl;
    cout << "we believe you should know" << endl;
    cout << "that we have " << ParkingSpaces;
    cout << " full-sized" << endl;
    cout << "parking spaces for your parking" << endl;
    cout << "pleasure." << endl;
    cout << endl;

    cout << "We do realize, however, that parking" << endl;
    cout << "is tight at " << StoreName << endl;
    cout << "and so we are going to double our" << endl;
    cout << "spaces from " << ParkingSpaces << " to ";
    cout << ParkingSpaces * 2;
    cout << ". Thank you again!" << endl << endl;

    float radius = 5;
    float area = radius * pi * pi;

    cout << "And remember, we sell " << radius;
    cout << " inch apple pies" << endl;
    cout << "for a full " << area << " square" << endl;
    cout << "inches of eating pleasure!" << endl;

    return 0;
}
