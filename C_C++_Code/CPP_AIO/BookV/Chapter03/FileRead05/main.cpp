#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void ReadFile(string filename)
{
    ifstream infile(filename.c_str());
    int num;

    cout << "File: " << filename << endl;
    bool done = false;
    while (!done)
    {
        infile >> num;
        if (infile.eof() == true)
        {
            done = true;
        }
        else
        {
            cout << num << endl;
        }
    }
    infile.close();
}

int main()
{
    ReadFile("../nums1.txt");
    ReadFile("../nums2.txt");
    return 0;
}
