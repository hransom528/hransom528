#include <iostream>
#include "boost/filesystem.hpp"

using namespace std;
using namespace boost::filesystem;

int main()
{
    // Check for the existence of the directory.
    if (! exists("Test"))
    {

        // Create the directory.
        create_directory(path("Test"));
        cout << "Created Directory Test" << endl;
    }
    else
        cout << "Directory Test Exists" << endl;

    // Check for the existence of the file.
    if (! exists("Test/Data.txt"))
    {
        // Create the file.
        ofstream File("Test/Data.txt");
        File << "This is a test!";
        File.close();
        cout << "Created File Data.txt" << endl;
    }
    else
        cout << "File Data.txt Exists" << endl;

    // Read the file.
    if (exists("Test/Data.txt"))
    {
        cout << "Data.txt contains " << file_size("Test/Data.txt")
             << " bytes." << endl;

        ifstream File("Test/Data.txt");
        string Data;

        while (! File.eof())
        {
            File >> Data;
            cout << Data << " ";
        }
        cout << endl;

        File.close();
    }
    else
        cout << "File Data.txt Doesn't Exist!" << endl;

    // Delete the file and directory.
    if (exists("Test/Data.txt"))
    {
        remove(path("Test/Data.txt"));
        cout << "Deleted Data.txt" << endl;
    }

    if (exists("Test"))
    {
        remove(path("Test"));
        cout << "Deleted Test" << endl;
    }
}
