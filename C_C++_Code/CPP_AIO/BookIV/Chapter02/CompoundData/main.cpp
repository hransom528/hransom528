#include <iostream>

using namespace std;

struct Point3D
{
    double x;
    double y;
    double z;
};

Point3D StartingPoint(float x)
{
    Point3D start;
    start.x = x;
    start.y = x * 2;
    start.z = x * 3;
    return start;
}

int main()
{
    Point3D MyPoint = StartingPoint(5.2);
    Point3D OtherPoint = StartingPoint(6.5);
    cout << MyPoint.x << endl;
    cout << MyPoint.y << endl;
    cout << MyPoint.z << endl;
    cout << endl;
    cout << OtherPoint.x << endl;
    cout << OtherPoint.y << endl;
    cout << OtherPoint.z << endl;
}
