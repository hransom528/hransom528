#include <iostream>
#include <map>

using namespace std;

int main()
{
    map<string, string> marriages;

    marriages["Tom"] = "Suzy";
    marriages["Harry"] = "Harriet";
    marriages["Tom"] = "Amy";

    cout << marriages["Tom"] << endl;
    cout << marriages["Harry"] << endl;

    return 0;
}
