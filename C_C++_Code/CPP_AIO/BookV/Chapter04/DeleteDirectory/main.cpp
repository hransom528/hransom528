#include <iostream>
#include <stdio.h>
#include <io.h>

using namespace std;

int main()
{
    if (rmdir("../abc") != 0)
    {
        cout << "Life is difficult sometimes, and" << endl;
        cout << "sometimes you just don't get what" << endl;
        cout << "you asked for. And this is one" << endl;
        cout << "such case. I just couldn't remove" << endl;
        cout << "the directory for you. Better" << endl;
        cout << "luck next time, my dear friend." << endl;
    }
    return 0;
}
