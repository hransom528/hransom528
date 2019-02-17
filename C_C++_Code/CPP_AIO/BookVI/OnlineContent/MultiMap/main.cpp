#include <iostream>
#include <map>

using namespace std;

int main()
{
    multimap<string, string> marriages;

    marriages.insert(pair<string, string>("Tom", "Suzy"));
    marriages.insert(pair<string, string>("Harry", "Harriet"));
    marriages.insert(pair<string, string>("Tom", "Amy"));

    for (multimap<string, string>::iterator Values = marriages.begin();
        Values != marriages.end(); ++Values)
        {
            cout << (*Values).first << " is married to " <<
                (*Values).second << endl;
        }

    cout << endl << "Women Married to Men Named Tom" << endl;
    multimap<string, string>::const_iterator Values =
        marriages.find("Tom");
    int Number = marriages.count("Tom");
    for (int i = 0; i < Number; i++)
    {
        cout << Values->second << endl;
        ++Values;
    }

    return 0;
}
