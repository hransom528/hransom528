/** Includes **/
#include <iostream>
#include <sstream>
#include <vector>

#include "Card.h"
#include "Deck.h"

using namespace std;

/** Defines **/
static Deck deck;
static vector<Card> player1;
static vector<Card> player2;
static int warCard = 4;

/** Functions **/
// If war occurs
static void goToWar() {
    while ((player1.size() < warCard || player2.size() < warCard) && warCard > 1) {
        warCard--;
    }

    if (player1.at(warCard - 1).compareTo(player2.at(warCard - 1)) > 0) {
        cout << "Player 1 wins" << endl;
        for(int i = 0; i <= warCard; i++) {
            player1.push_back(player1.front());
            player1.erase(player1.begin());
            if (player2.size() > 0) {
                player1.push_back(player2.front());
                player2.erase(player2.begin());
            }

        }
    }
    else if (player1.at(warCard - 1).compareTo(player2.at(warCard - 1)) < 0) {
        cout << "Player 2 wins" << endl;
        for(int i = 0; i <= warCard; i++) {
            player2.push_back(player2.front());
            player2.erase(player2.begin());
            if (player1.size() > 0) {
                player2.push_back(player1.front());
                player1.erase(player1.begin());
            }
        }
    }
    else {
        cout << "WAR!" << endl;
        warCard += 4;
        goToWar();
    }
}

// Resets game
void reset() {
    deck.reset();
    int warCard = 4;
    player1.clear();
    player2.clear();
}

/** Main **/
int main() {
    char loopChar = 'y';
    while (loopChar == 'y' && loopChar != 'n') {
        deck.shuffle();

        //Deals out all cards in the deck
        while (!deck.isEmpty()) {
            player1.push_back(deck.deal());
            player2.push_back(deck.deal());
        }

        //While both players still have cards
        while ((!player1.empty()) && (!player2.empty())) {
            cout << "Player 1 plays: " << player1.front().toString() << endl;
            cout << "Player 2 plays: " << player2.front().toString() << endl;

            //Compares cards drawn
            if (player1.at(0).compareTo(player2.at(0)) > 0) {
                cout << "Player 1 wins" << endl;
                player1.push_back(player1.at(0));
                player1.erase(player1.begin());
                if (player2.size() > 0) {
                    player1.push_back(player2.at(0));
                    player2.erase(player2.begin());
                }
            }
            else if (player1.at(0).compareTo(player2.at(0)) < 0) {
                cout << "Player 2 wins" << endl;
                player2.push_back(player2.at(0));
                player2.erase(player2.begin());
                if (player1.size() > 0) {
                    player2.push_back(player1.at(0));
                    player1.erase(player1.begin());
                }
            }
            else {
                cout << "WAR!" << endl;
                goToWar();
            }
        }
        cout << "\n" << endl;
        cout << "Player 1's Cards: " << player1.size() << " Cards" << endl;
        cout << "Player 2's Cards: " << player2.size() << " Cards" << endl;

        // Determines winner
        if (player1.size() != 0) {
            cout << "Player 1 wins the game!" << endl;
        }
        else {
            cout << "Player 2 wins the game!" << endl;
        }

        // Gets input for next round
        cout << "Would you like to simulate another game (y/n)?" << endl;
        cin >> loopChar;
        while (loopChar != 'y' && loopChar != 'n') {
            cout << "Please input a valid response: " << endl;
            cin >> loopChar;
        }

        // Resets for next round
        reset();
    }

    // Ends game
    cout << "Thank you for playing War++!" << endl;
    return 0;
}
