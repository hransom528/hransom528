#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double a = 0; //var for A value
    double b = 0; //var for B value
    double c = 0; //var for C value
    double result1 = 0; //first result (when the +- is addition)
    double result2 = 0; //second result (when the +- is subtraction)
    double numToSqrt = 0; //Temporarily stores the number for the sqrt function

    //Gets A value
    cout << "Welcome to the Quadratic Formula Calculator! \n Please input your A, B, and C values!" << endl;
    cout << "A: " << endl;
    cin >> a;

    //Gets B value
    cout << "B: " << endl;
    cin >> b;

    //Gets C value
    cout << "C: " << endl;
    cin >> c;

    //Does the calculations
    numToSqrt = ((pow(b, 2)) - ((4 * a) * c));
    result1 = -((-(b) + sqrt(numToSqrt)) / 2 * a);
    result2 = -((-(b) - sqrt(numToSqrt)) / 2 * a);

    //Outputs the two results
    cout << "Result 1: " << result1 << endl;
    cout << "Result 2: " << result2 << endl;
    return 0;
}
