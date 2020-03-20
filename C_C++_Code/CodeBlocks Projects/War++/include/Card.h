#ifndef CARD_H
#define CARD_H
#include <string>

class Card {
     private:
        std::string suit; //!< Member variable "suit"
        int rank; //!< Member variable "rank"

    public:
        /**Constructor*/
        Card(std::string newSuit, int newRank) {
            this->suit = newSuit;
            this->rank = newRank;
        }

        /** Access suit
         * \return The current value of suit
         */
        std::string getSuit() { return suit; }

        /** Access rank
         * \return The current value of rank
         */
        int getRank() { return rank; }

        /**
        * equals : Tests to see if a Card object is the same as another Card
        * \param otherCard : Card object of another card
        * \return true if the cards are the same, false otherwise.
        */
        bool equals(Card otherCard);

        /**
        * compareTo : Finds the difference between this Card's rank and
        * 				another Card's rank
        * @param otherCard : Card object of another card
        * @return the int difference between the rank of this Card
        */
        int compareTo(Card otherCard);

        /**
        * rankToString : Returns a String for the rank.
        * 		14 = "Ace"
        * 		13 = "King"
        * 		12 = "Queen"
        * 		11 = "Jack"
        * @return String of the rank
        */
        std::string rankToString();

        /**
        * toString : Returns a string that describes the card by rank and suit.
        * 				Should call the rankToString method.
        * 		Examples:
        * 			"Ace of spades"
        * 			"Jack of hearts"
        * 			"5 of clubs"
        */
        std::string toString();
};

#endif // CARD_H
