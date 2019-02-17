#include <iostream>
#include <unordered_map>

using namespace std;

int main()
{
    hash<const char*> MyHash;

    cout << "The hash of \"Hello World\" is:" << endl;
    cout << MyHash("Hello World") << endl;
    cout << "while the hash of \"Goodbye Cruel World\" is:" << endl;
    cout << MyHash("Goodbye Cruel World") << endl;

    return 0;
}
