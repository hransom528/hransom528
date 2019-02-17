#include <iostream>

using namespace std;

class Observer;

class Subject
{
    friend class Observer;

protected:
    int Count;
    Observer *List[100];
    void AddObserver(Observer *Item);
    void RemoveObserver(Observer *Item);

public:
    Subject() { Count = 0; }
    void Event();
};

class Observer
{
protected:
    Subject *subj;

public:
    virtual void Respond() = 0;

    Observer(Subject *asubj)
    {
        subj = asubj;
        subj->AddObserver(this);
    }

    virtual ~Observer() { subj->RemoveObserver(this); }
};

class Dog : public Observer
{
public:
    void Respond();
    Dog(Subject *asubj) : Observer(asubj) {}
};

class Police : public Observer
{
protected:
    string name;

public:
    Police(Subject *asubj, string myname) : Observer(asubj) { name = myname; }
    void Respond();
};

void Dog::Respond()
{
    cout << "Bark bark" << endl;
}

void Police::Respond()
{
    cout << name << ": 'Drop the weapon! Now!'" << endl;
}

void Subject::AddObserver(Observer *Item)
{
    List[Count] = Item;
    Count++;
}

void Subject::RemoveObserver(Observer *Item)
{
    int i;
    bool found = false;
    for (i=0; i < Count; i++)
    {
        if (found)
        {
        }
        else if (List[i] == Item)
        {
            found = true;
            List[i] = List[i+1];
        }
    }

    if (found)
    {
        Count--;
    }
}

void Subject::Event()
{
    int i;
    for (i=0; i < Count; i++)
    {
        List[i]->Respond();
    }
}

int main()
{
    Subject Alarm;

    Police *TJHooker = new Police(&Alarm, "TJ");

    cout << "TJ on the beat" << endl;
    Alarm.Event();
    cout << endl;
    cout << "TJ off for the day" << endl;
    delete TJHooker;
    Alarm.Event();

    return 0;
}
