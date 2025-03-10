#include "Deck.h"
#include <vector>
#include <iostream>
#include <algorithm>
#include <random>
#include <time.h>
#include <sstream>

using namespace std;

Deck::Deck() {
    reset();
}

void Deck::reset() {
    this->addSuit("spades");
    this->addSuit("hearts");
    this->addSuit("diamonds");
    this->addSuit("clubs");
}

void Deck::addSuit(string suit) {
    for (int i=2; i <= 14; i++ ) {
        this->cards.push_back(Card(i, suit));
    }
}

bool Deck::isEmpty() {
    return this->cards.empty();
}

int Deck::getSize() {
    return this->cards.size();
}

Card Deck::deal() {
    Card returnCard;
    if (!this->isEmpty()) {
        returnCard = this->cards.back();
        cards.pop_back();
        return returnCard;
    }
    else {
        cout << "Error, empty deck!" << endl;
        return returnCard;
    }
}

void Deck::shuffle() {
    if (cards.size() < MAX_SIZE) {
        return;
    }
    unsigned seed = time(0);
    std::shuffle(begin(cards), end(cards), default_random_engine(seed));
}

string Deck::toString() {
    stringstream ss;
    for (int i = 0; i < cards.size(); i++) {
        ss << cards.at(i).toString() << "\n";
    }
    return ss.str();
}
