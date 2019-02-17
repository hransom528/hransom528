#include <iostream>
#include <list>

using namespace std;

class Duck
{
public:
    string name;
    int weight;
    int length;
};

ostream& operator << (ostream &out, const Duck &duck)
{
    cout << "(" << duck.name;
    cout << "," << duck.weight;
    cout << "," << duck.length;
    cout << ")";
    return out;
}

void DumpDucks(list<Duck> *mylist)
{
    list<Duck>::iterator iter = mylist->begin();

    while (iter != mylist->end())
    {
        cout << *iter << endl;
        iter++;
    }
}

list<Duck>::iterator MoveToPosition(list<Duck> *mylist, int pos)
{
    list<Duck>::iterator res = mylist->begin();

    for (int loop = 1; loop <= pos; loop++)
    {
        res++;
    }

    return res;
}

int main()
{
    list<Duck> Inarow;

    // Push some at the beginning
    Duck d1 = {"Jim", 20, 15}; // Braces notation!
    Inarow.push_front(d1);

    Duck d2 = {"Sally", 15, 12};
    Inarow.push_front(d2);

    // Push some at the end
    Duck d3 = {"Squakie", 18, 25};
    Inarow.push_front(d3);

    Duck d4 = {"Trumpeter", 19, 26};
    Inarow.push_front(d4);

    Duck d5 = {"Sneeky", 12, 13};
    Inarow.push_front(d5);

    // Display the ducks
    cout << "===========" << endl;
    DumpDucks(&Inarow);

    // Reverse
    Inarow.reverse();
    cout << "===========" << endl;
    DumpDucks(&Inarow);

    // Splice
    // Need another list for this
    list<Duck> extras;

    Duck d6 = {"Grumpy", 8, 8};
    extras.push_back(d6);

    Duck d7 = {"Sleepy", 8, 8};
    extras.push_back(d7);

    Duck d8 = {"Ornery", 8, 8};
    extras.push_back(d8);

    Duck d9 = {"Goofy", 8, 8};
    extras.push_back(d9);

    cout << "===========" << endl;
    cout << "extras:" << endl;
    DumpDucks(&extras);

    list<Duck>::iterator first =
        MoveToPosition(&extras, 1);

    list<Duck>::iterator last =
        MoveToPosition(&extras, 3);

    list<Duck>::iterator into =
        MoveToPosition(&Inarow, 2);

    Inarow.splice(into, extras, first, last);

    cout << "===========" << endl;
    cout << "extras after splice:" << endl;
    DumpDucks(&extras);

    cout << "===========" << endl;
    cout << "Inarow after splice:" << endl;
    DumpDucks(&Inarow);

    return 0;
}
