#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    string word;
    ifstream infile("../MyFile.txt");
    infile >> word;
    cout << word << endl;
    infile.close();

    return 0;
}
