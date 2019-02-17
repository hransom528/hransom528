#include <iostream>
#include "boost/tokenizer.hpp"

using namespace std;
using namespace boost;

int main()
{
    // Define the test string.
    string MyString = "This is a test string!";

    // Obtain tokens from the string.
    tokenizer<> Tokens(MyString);

    // Display each token on screen.
    tokenizer<>::iterator Iterate;
    for (Iterate = Tokens.begin(); Iterate != Tokens.end(); Iterate++)
        cout << *Iterate << endl;

    return 0;
}
