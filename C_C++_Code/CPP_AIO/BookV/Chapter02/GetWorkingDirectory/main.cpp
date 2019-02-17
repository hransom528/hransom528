#include <iostream>
#include <direct.h>
#include <stdlib.h>

using namespace std;

int main()
{
    char CurrentPath[_MAX_PATH];
    getcwd(CurrentPath, _MAX_PATH);
    cout << CurrentPath << endl;
    return 0;
}
