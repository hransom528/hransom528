#include <iostream>
#include <string>
#include <fstream>

using namespace std;

void WriteString(ofstream &file, string words)
{
    file << words;
    file << ";";
}

int main()
{
    ofstream delimfile("../delims.txt");

    WriteString(delimfile, "This is a dog");
    WriteString(delimfile, "Some dogs bite");
    WriteString(delimfile, "Some dogs don't bite");
    WriteString(delimfile, "Humans that is");
    WriteString(delimfile, "All dogs bite");
    WriteString(delimfile, "Food that is");
    WriteString(delimfile, "I say, food food food.");

    delimfile.close();
    return 0;
}
