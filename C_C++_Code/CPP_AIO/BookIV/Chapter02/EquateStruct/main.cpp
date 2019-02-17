#include <iostream>

using namespace std;

struct Point3D
{
    double x;
    double y;
    double z;
};

int main()
{
    Point3D FirstPoint = { 10.5, 22.25, 30.8 };
    Point3D SecondPoint = FirstPoint;
    cout << SecondPoint.x << endl;
    cout << SecondPoint.y << endl;
    cout << SecondPoint.z << endl;
    return 0;
}
