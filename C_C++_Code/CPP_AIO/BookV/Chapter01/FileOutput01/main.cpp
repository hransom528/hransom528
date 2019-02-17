#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream outfile("../MyFile.txt");
    outfile << "Hi" << endl;
    outfile.close();

    return 0;
}
