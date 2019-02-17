#include <iostream>
#include <vector>

using namespace std;

int main()
{
    vector<string> Words;

    Words.push_back("Blue");
    Words.push_back("Green");
    Words.push_back("Teal");
    Words.push_back("Brick");
    Words.push_back("Purple");
    Words.push_back("Brown");
    Words.push_back("LightGray");

    // Define a random iterator.
    vector<string>::iterator Iter = Words.begin();

    // Access random points.
    Iter += 5;
    cout << *Iter << endl;

    Iter -= 2;
    cout << *Iter << endl;

    return 0;
}
