#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ifstream infile("../MyFile.txt");
    if (infile.fail())
    {
        cout << "Couldn't open the file!" << endl;
        return 0;
    }
    infile.close();

    ofstream outfile("../MyFile.txt", ios::app);
    outfile << "Hi" << endl;
    outfile.close();

    return 0;
}
