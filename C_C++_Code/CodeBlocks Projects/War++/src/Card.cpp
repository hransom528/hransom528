#include "Card.h"
#include <sstream>

//ctor
Card::Card(int nRank, string nSuit) {
    this->cardRank = nRank;
    this->cardSuit = nSuit;
}

bool Card::equals(Card otherCard) {
    if (this->cardRank == otherCard.getRank()) {
        return true;
    }
    else {
        return false;
    }
}

int Card::compareTo(Card otherCard) {
    return (this->cardRank - otherCard.getRank());
}

string Card::rankToString() {
    switch (this->cardRank) {
    case 14:
        return "Ace";
        break;
    case 13:
        return "King";
    case 12:
        return "Queen";
    case 11:
        return "Jack";
    default:
        stringstream ss;
        ss << this->cardRank;
        return ss.str();
        break;
    }
}

string Card::toString() {
    stringstream ss;
    ss << this->rankToString() << " of " << this->cardSuit << endl;
    return ss.str();
}
