#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream outfile("outfile.txt");
    outfile << "Lookit me! I’m in a file!" << endl;
    int x = 200;
    outfile << x << endl;
    outfile.close();
    return 0;
}
