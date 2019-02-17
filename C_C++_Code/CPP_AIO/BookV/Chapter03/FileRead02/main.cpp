#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void WriteFile(string filename, int count, int start)
{
    ofstream outfile(filename.c_str());
    outfile << count << endl;
    int i;
    for (i=0; i<count; i++)
    {
        outfile << start + i  << endl;
    }
    outfile.close();
}

int main()
{
    WriteFile("../nums1.txt", 5, 100);
    WriteFile("../nums2.txt", 6, 200);
    return 0;
}
