#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    ifstream cfile("Config.config");
    string Name;
    string Greeting;

    if (cfile.good())
    {
        cfile >> Name;
        cfile >> Greeting;

        cout << Greeting << " " << Name << endl;
    }
    else
    {
        cfile.close();
        ofstream cfile("Config.config");

        cout << "What is your name? " << endl;
        cin >> Name;
        cout << "How do you want to be greeted?" << endl;
        cin >> Greeting;

        cfile << Name << endl;
        cfile << Greeting << endl;
    }

    cfile.close();

    return 0;
}
