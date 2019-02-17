#include <iostream>
#include <map>

using namespace std;

class Scrumptious
{
public:
    string Dessert;
};

bool operator < (const Scrumptious & first,
const Scrumptious & second)
{
    return first.Dessert < second.Dessert;
}

class Nutrition
{
public:
    int VitaminC;
    int Potassium;
};

int main()
{
    map<Scrumptious, Nutrition> ItsGoodForMe;

    Scrumptious ap = {"Apple Pie"}; // Braces notation!
    Nutrition apn = {7249, 9722};

    Scrumptious ic = {"Ice Cream"};
    Nutrition icn = {2459, 19754};

    Scrumptious cc = {"Chocolate Cake"};
    Nutrition ccn = {9653, 24905};

    Scrumptious ms = {"Milk Shake"};
    Nutrition msn = {46022, 5425};

    ItsGoodForMe[ap] = apn;
    ItsGoodForMe[ic] = icn;
    ItsGoodForMe[cc] = ccn;
    ItsGoodForMe[ms] = msn;

    map<Scrumptious,Nutrition> Duplicate = ItsGoodForMe;
    map<Scrumptious,Nutrition> AnotherDuplicate(ItsGoodForMe);

    ItsGoodForMe[ap].Potassium = 20;
    cout << ItsGoodForMe[ap].Potassium << endl;
    cout << Duplicate[ap].Potassium << endl;
    cout << AnotherDuplicate[ap].Potassium << endl;

    return 0;
}
