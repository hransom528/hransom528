#include <iostream>
#include <map>

using namespace std;

template<typename T>
struct MyDef
{
    typedef map<string, T> Type;
};

int main()
{
    MyDef<string>::Type marriages;

    marriages["Tom"] = "Suzy";
    marriages["Harry"] = "Harriet";

    cout << marriages["Tom"] << endl;
    cout << marriages["Harry"] << endl;

    return 0;
}
