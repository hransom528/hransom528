#include <iostream>
#include "Card.h"

using namespace std;

int main() {
    Card *card1 = new Card("Spades", 5);
    cout << card1->toString() << endl;
    return 0;
}
