#include <string>
#include <sstream>

class Card {
    private:
        std::string suit;
        int rank;

    public:
        //ctor
        Card(std::string newSuit, int newRank) {
            this->suit = newSuit;
            this->rank = newRank;
        }

        //getRank
        int getRank() {
            return this->rank;
        }

        //getSuit
        std::string getSuit() {
            return this->suit;
        }

        //equals
        int equals(Card otherCard) {
            return (this->rank == otherCard.getRank());
        }

        //compareTo
        int compareTo(Card otherCard) {
            return (this->getRank() - otherCard.getRank());
        }

        //rankToString
        std::string rankToString() {
            switch (this->rank) {
            case 14:
                return "Ace";
                break;
            case 13:
                return "King";
                break;
            case 12:
                return "Queen";
                break;
            case 11:
                return "Jack";
                break;
            default:
                std::stringstream ss;
                ss << this->rank;
                return (ss.str());
                break;
            }
        }

        //toString
        std::string toString() {
            std::stringstream ss;
            ss << rankToString() << " of " << this->suit;
                return ss.str();
        }
};
