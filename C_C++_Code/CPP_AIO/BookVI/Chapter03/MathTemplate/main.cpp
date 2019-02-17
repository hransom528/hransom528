#include <iostream>
#include <cmath>

using namespace std;

template<typename T>
T Area(T height, T length)
{
    return height * length;
}

const double PI = 4.0*atan(1.0);

template<typename T>
T CircleArea(T radius)
{
    double result;

    result = PI * radius * radius;

    // This version truncates the value.
    return (T)result;
}

template<typename T>
T TriangleArea(T base, T height)
{
    double result;

    result = base * height * 0.5;

    return (T)result;
}

int main()
{
    cout << "4 X 4 Areas:" << endl;
    cout << "Square: " << Area<int>(4, 4) << endl;
    cout << "Circle: " << CircleArea<int>(2) << endl;
    cout << "Triangle: " << TriangleArea<int>(4, 4) << endl;
    cout << "Using a value of pi of: " << PI << endl;
    return 0;
}
