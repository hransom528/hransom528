#include <iostream>
#include <string>

using namespace std;

void ProcessData()
{
    throw new string("Oops, I found some bad data!");
}

int main()
{
    try
    {
        ProcessData();
        cout << "No problems!" << endl;
    }
    catch (string *excep)
    {
        cout << "Found an error. Here's the message.";
        cout << endl;
        cout << *excep;
        cout << endl;
    }
    cout << "All finished." << endl;

    return 0;
}
