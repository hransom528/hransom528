#include <iostream>

using namespace std;

template<typename K, typename V, int S>
class MyMap
{
protected:
    K key[S];
    V value[S];
    bool used[S];
    int Count;

    int Find(K akey)
    {
        int i;
        for (i=0; i<S; i++)
        {
            if (used[i] == false)
                continue;
            if (key[i] == akey)
            {
                return i;
            }
        }
        return -1;
    }

    int FindNextAvailable()
    {
        int i;
        for (i=0; i<S; i++)
        {
            if (used[i] == false)
                return i;
        }
        return -1;
    }

public:
    MyMap()
    {
        int i;
        for (i=0; i<S; i++)
        {
            used[i] = false;
        }
    }

    void Set(K akey, V avalue)
    {
        int i = Find(akey);
        if (i > -1)
        {
            value[i] = avalue;
        }
        else
        {
            i = FindNextAvailable();
            if (i > -1)
            {
                key[i] = akey;
                value[i] = avalue;
                used[i] = true;
            }
            else
                cout << "Sorry, full!" << endl;
        }
    }

    V Get(K akey)
    {
        int i = Find(akey);
        if (i == -1)
        {
            return 0;
        }
        else
        {
            return value[i];
        }
    }
};

int main()
{
    MyMap<char,int,10> mymap;

    mymap.Set('X',5);
    mymap.Set('Q',6);
    mymap.Set('X',10);

    cout << mymap.Get('X') << endl;
    cout << mymap.Get('Q') << endl;

    return 0;
}
