#include <iostream>
#include <set>
#include <algorithm>

using namespace std;

void DumpClass(set<string> *myset)
{
    set<string>::iterator iter = myset->begin();

    while (iter != myset->end())
    {
        cout << *iter << endl;
        iter++;
    }
}

int main()
{
    set<string> EnglishClass;
    set<string> HistoryClass;

    EnglishClass.insert("Zeus");
    EnglishClass.insert("Magellan");
    EnglishClass.insert("Vulcan");
    EnglishClass.insert("Ulysses");
    EnglishClass.insert("Columbus");

    HistoryClass.insert("Vulcan");
    HistoryClass.insert("Ulysses");
    HistoryClass.insert("Ra");
    HistoryClass.insert("Odin");

    set<string> Union;
    set<string> Intersection;

    insert_iterator<set<string> >
       IntersectIterate(Intersection, Intersection.begin());

    insert_iterator<set<string> >
        UnionIterate(Union, Union.begin());

    set_intersection(EnglishClass.begin(),
        EnglishClass.end(),
        HistoryClass.begin(), HistoryClass.end(),
        IntersectIterate);
    cout << "===Intersection===" << endl;
    DumpClass(&Intersection);

    set_union(EnglishClass.begin(),
        EnglishClass.end(),
        HistoryClass.begin(), HistoryClass.end(),
        UnionIterate);
    cout << endl << "===Union===" << endl;
    DumpClass(&Union);

    return 0;
}
