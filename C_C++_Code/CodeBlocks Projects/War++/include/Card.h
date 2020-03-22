#ifndef CARD_H
#define CARD_H

#include <string>
using namespace std;

class Card {
    public:
        /** Default constructor */
        Card(int nRank, string nSuit);

        /** Access cardRank
         * \return The current value of cardRank
         */
        int getRank() { return cardRank; }
        /** Access cardSuit
         * \return The current value of cardSuit
         */
        string getSuit() { return cardSuit; }

        bool equals(Card otherCard);

        int compareTo(Card otherCard);

        string rankToString();

        string toString();

    private:
        int cardRank; //!< Member variable "cardRank"
        string cardSuit; //!< Member variable "cardSuit"
};
#endif // CARD_H
