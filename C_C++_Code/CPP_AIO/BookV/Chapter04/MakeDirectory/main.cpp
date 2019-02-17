#include <iostream>
#include <stdio.h>
#include <io.h>

using namespace std;

int main()
{
    if (mkdir("../abc") != 0)
    {
        cout << "I'm so sorry. I was not" << endl;
        cout << "able to create your directory" << endl;
        cout << "as you asked of me. I do hope" << endl;
        cout << "you are still able to achieve" << endl;
        cout << "your goals in life. Now go away." << endl;
    }
    return 0;
}
