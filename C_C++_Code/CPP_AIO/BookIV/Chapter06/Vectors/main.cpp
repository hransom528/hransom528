#include <iostream>
#include <vector>

using namespace std;

int main()
{
    vector<string> names;

    names.push_back("Tom");
    names.push_back("Dick");
    names.push_back("Harry");
    names.push_back("April");
    names.push_back("May");
    names.push_back("June");

    cout << names[0] << endl;
    cout << names[5] << endl;

    return 0;
}
