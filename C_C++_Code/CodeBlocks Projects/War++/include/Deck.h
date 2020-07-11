#ifndef DECK_H
#define DECK_H

#include <vector>
#include <string>
#include "Card.h"

using namespace std;

class Deck {
    public:
        /** Default constructor */
        Deck();

        void reset();

        void addSuit(string suit);

        bool isEmpty();

        int getSize();

        Card deal();

        void shuffle();

        string toString();

    private:
        static const int MAX_SIZE = 52; //!< Member variable "MAX_SIZE"
        vector<Card> cards;
};
#endif // DECK_H
