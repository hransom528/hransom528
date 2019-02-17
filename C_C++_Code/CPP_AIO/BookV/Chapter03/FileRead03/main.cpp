#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void ReadFile(string filename)
{
    ifstream infile(filename.c_str());
    int count;
    int i;
    int num;

    cout << "File: " << filename << endl;
    infile >> count;
    cout << "This file has " << count << " items." << endl;
    for (i=0; i<count; i++)
    {
        infile >> num;
        cout << num << endl;
    }
    infile.close();
}

int main()
{
    ReadFile("../nums1.txt");
    ReadFile("../nums2.txt");
    return 0;
}
