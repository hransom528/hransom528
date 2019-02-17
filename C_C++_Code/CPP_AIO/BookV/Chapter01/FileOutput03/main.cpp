#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ifstream infile("../MyFile.txt");
    if (!infile.fail())
    {
        cout << "The file already exists!" << endl;
        return 0;
    }
    infile.close();

    ofstream outfile("../MyFile.txt");
    outfile << "Hi" << endl;
    outfile.close();

    return 0;
}
