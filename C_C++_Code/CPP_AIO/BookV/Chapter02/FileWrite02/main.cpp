#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream myfile("numbers.txt");
    myfile.setf(ios_base::scientific);
    myfile << 154272.524 << endl;
    myfile.close();
}
