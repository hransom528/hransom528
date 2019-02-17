#include <iostream>
#include "boost/regex.hpp"

using namespace std;
using namespace boost;

int main()
{
    // Obtain an input from the user.
    char MyNumber[80];
    cout << "Type a three-digit number: ";
    cin >> MyNumber;

    // Define the regular expression.
    regex Expression("[0-9][0-9][0-9]");

    // Create a variable to hold the matches.
    cmatch Matches;

    // Preform a matching check.
    if (regex_match(MyNumber, Matches, Expression))
    {
        cout << "You typed: " << Matches << endl;
    }
    else
    {
        cout << "Not a three-digit number!" << endl;
    }

    // Perform a search check.
    if (regex_search(MyNumber, Matches, Expression))
    {
        cout << "Found: " << Matches << endl;
    }
    else
    {
        cout << "No three-digit number found!" << endl;
    }

    return 0;
}
