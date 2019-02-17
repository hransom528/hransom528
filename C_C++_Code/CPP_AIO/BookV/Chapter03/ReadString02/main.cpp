#include <iostream>
#include <string>
#include <fstream>

using namespace std;

string ReadString(ifstream &file)
{
    char buf[1024]; // Make sure this is big enough!
    file.getline(&(buf[0]), 1024, ';');
    return string(buf);
}

int main()
{
    ifstream delimfile("../delims.txt");


    while (1)
    {
        string words = ReadString(delimfile);
        if (delimfile.eof() == true)
            break;
        cout << words << endl;
    }
    delimfile.close();
    return 0;
}
