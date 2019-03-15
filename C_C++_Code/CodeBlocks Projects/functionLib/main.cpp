#include <iostream>
#include <cmath>
using namespace std;

//Main function, for testing
int main() {
    return 0;
}

//Takes in the A, B, and C values of a quadratic and computes the two zeroes.
int quadFormCalc(double a, double b, double c)
{
    double result1 = 0; //first result (when the +- is addition)
    double result2 = 0; //second result (when the +- is subtraction)
    double numToSqrt = 0; //Temporarily stores the number for the sqrt function

    //Does the calculations0g
    numToSqrt = ((pow(b, 2)) - ((4 * a) * c));
    result1 = -((-(b) + sqrt(numToSqrt)) / 2 * a);
    result2 = -((-(b) - sqrt(numToSqrt)) / 2 * a);

    //Outputs the two results
    return result1, result2;
}

