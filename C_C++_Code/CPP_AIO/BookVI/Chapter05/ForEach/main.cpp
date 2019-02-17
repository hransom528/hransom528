#include <iostream>
#include <vector>
#include "boost/foreach.hpp"

using namespace std;
using namespace boost;

int main()
{
    // Create a vector and store values in it.
    vector<string> names;

    names.push_back("Tom");
    names.push_back("Dick");
    names.push_back("Harry");
    names.push_back("April");
    names.push_back("May");
    names.push_back("June");

    // Iterate through the vector.
    BOOST_FOREACH(string Name, names)
        cout << Name << endl;

    // Iterate backward too!
    cout << endl << "Backward:" << endl;
    BOOST_REVERSE_FOREACH(string Name, names)
        cout << Name << endl;

    return 0;
}
