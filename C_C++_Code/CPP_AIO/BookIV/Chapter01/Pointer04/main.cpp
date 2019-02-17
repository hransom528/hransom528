#include <iostream>

using namespace std;

typedef char **StringArray;
typedef char *PChar;

void ChangeAsPointer(StringArray *array)
{
    StringArray NameArray = new PChar[3];
    NameArray[0] = (char *) "Tom";
    NameArray[1] = (char *) "Harry";
    NameArray[2] = (char *) "Suzy";
    *array = NameArray;
}

int main()
{
    StringArray OrigList = new PChar[3];
    OrigList[0] = (char *) "John";
    OrigList[1] = (char *) "Paul";
    OrigList[2] = (char *) "George";
    StringArray CopyList = OrigList;
    ChangeAsPointer(&OrigList);
    cout << OrigList[0] << endl;
    cout << OrigList[1] << endl;
    cout << OrigList[2] << endl << endl;
    cout << CopyList[0] << endl;
    cout << CopyList[1] << endl;
    cout << CopyList[2] << endl;
}
