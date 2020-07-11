// Calculates Pi to within a threshold
// Harris Ransom
#include <iostream>
#include <cmath>

using namespace std;

int main() {
    // Vars
    double_t test;
    double threshold;   // Initialized to >.1 for input loop
    double piVal;
    char loopChar = 'y';
    int i;
    int sign;
    int counter = 0;

    // Loops until user exits
    while (loopChar != 'n') {
        // Resets values
        threshold = 1;
        piVal     = 0;
        i         = 1;
        sign      = 1;
        counter     = 0;

        // Gets input
        while (threshold > .1) {
            cout << "What is the threshold you wish to use (.1 or less): " << endl;
            cin >> threshold;
        }

        // Calculates pi
        while (abs((piVal * 4) - M_PI) > threshold) {
            // Steps through calculation algorithm
            piVal += ((double) sign / i);
            sign *= -1;
            i += 2;
            counter += 1;
        }
        piVal *= 4;

        // Outputs results
        cout << "C++ Pi Value: " << M_PI << endl;
        cout << "Calculated Pi: " << piVal << endl;
        cout << " Number of iterations: " << counter << endl;

        // Loops
        cout << "Would you like to enter another threshold (y/n)? " << endl;
        cin >> loopChar;

    }
    cout << "Thank you for approximating Pi." << endl;
    return 0;
}
