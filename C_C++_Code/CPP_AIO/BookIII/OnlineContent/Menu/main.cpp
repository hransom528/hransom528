#include <iostream>

using namespace std;

int main()
{
    int Selected = 0;

    while (Selected != 4)
    {
        cout << "Choose a Color" << endl << endl;
        cout << "1. Blue" << endl;
        cout << "2. Green" << endl;
        cout << "3. Orange" << endl;
        cout << "4. Quit" << endl << endl;

        cin >> Selected;

        switch (Selected)
        {
        case 1:
            cout << "You selected blue!" << endl << endl;
            break;
        case 2:
            cout << "You selected green!" << endl << endl;
            break;
        case 3:
            cout << "You selected orange!" << endl << endl;
            break;
        }
    }
    return 0;
}
