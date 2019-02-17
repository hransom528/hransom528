#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    string weight;
    string height;
    string width;
    string depth;

    ifstream MyFile("Numbers.txt");
    MyFile >> weight;
    MyFile >> height;
    MyFile >> width;
    MyFile >> depth;

    cout << "Weight = " << weight << "\r\n";
    cout << "Height = " << height << "\r\n";
    cout << "Width  = " << width << "\r\n";
    cout << "Depth  = " << depth;
}
