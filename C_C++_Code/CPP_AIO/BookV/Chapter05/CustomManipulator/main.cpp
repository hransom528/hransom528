#include <iostream>
#include <string>
#include <fstream>
#include <map>

using namespace std;

class MicrowaveOven
{
    friend ostream &operator <<(ostream &out,
        MicrowaveOven &oven);
public:
    typedef map<ostream *, bool> FlagMap;
    int HighVoltageRadiation;
    int RadioactiveFoodCount;
    int LeakLevel;
    string OvenName;
    static FlagMap Flags;
};

MicrowaveOven::FlagMap MicrowaveOven::Flags;
ostream &operator <<(ostream &out, MicrowaveOven &oven)
{
    bool full = true;
    MicrowaveOven::FlagMap::iterator iter =
        MicrowaveOven::Flags.find(&out);
    if (iter != MicrowaveOven::Flags.end())
    {
        full = iter->second;
    }

    if (full)
    {
        out << "High Voltage Radiation: ";
        out << oven.HighVoltageRadiation << endl;
        out << "Radioactive Food Count: ";
        out << oven.RadioactiveFoodCount << endl;
        out << "Leak Level: ";
        out << oven.LeakLevel << endl;
        out << "Oven Name: ";
        out << oven.OvenName;
    }
    else
    {
        out << oven.HighVoltageRadiation << ",";
        out << oven.RadioactiveFoodCount << ",";
        out << oven.LeakLevel << ",";
        out << oven.OvenName;
    }

    return out;
}

istream &operator >(istream &in, MicrowaveOven &oven)
{
    in >> oven.HighVoltageRadiation;
    in >> oven.RadioactiveFoodCount;
    in >> oven.LeakLevel;
    in >> oven.OvenName;
    return in;
}

struct FullOvenManip {};

void FullOvenInfo(FullOvenManip x) {}
typedef void(*FullPtr)(FullOvenManip);

ostream &operator << (ostream &out, FullPtr)
{
    MicrowaveOven::Flags[&out] = true;
    return out;
}

struct MinOvenManip {};

void MinOvenInfo(MinOvenManip x) {}
typedef void(*MinPtr)(MinOvenManip);

ostream &operator << (ostream &out, MinPtr)
{
    MicrowaveOven::Flags[&out] = false;
    return out;
}

int main()
{
    MicrowaveOven myoven;
    myoven.HighVoltageRadiation = 9832;
    myoven.RadioactiveFoodCount = 7624;
    myoven.LeakLevel = 3793;
    myoven.OvenName = "Burnmaster";

    cout << myoven << endl;
    cout << "============" << endl;
    cout << FullOvenInfo << myoven << endl;
    cout << "============" << endl;
    cout << MinOvenInfo << myoven << endl;

    return 0;
}
