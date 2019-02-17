#include <iostream>
#include <string>
#include <map>

using namespace std;

class Peripheral {
public:
    string Name;
    int Price;
    int SerialNumber;
    Peripheral(string aname, int aprice, int aserial) :
        Name(aname), Price(aprice),
        SerialNumber(aserial) {}
};
class Printer : public Peripheral {
public:
    enum PrinterType {laser, inkjet};
    PrinterType Type;
    Printer(string aname, PrinterType atype, int aprice,
        int aserial) :
        Peripheral(aname, aprice, aserial), Type(atype) {}
};
typedef map<string, Peripheral *> PeripheralMap;
class PeripheralList {
public:
    PeripheralMap list;
    virtual Peripheral *GetPeripheralByName(string name);
    void AddPeripheral(string name, Peripheral *per);
};
class PrinterList : public PeripheralList {
public:
    Printer *GetPeripheralByName(string name);
};
Peripheral *PeripheralList::GetPeripheralByName
 (string name){
    return list[name];
}
void PeripheralList::AddPeripheral(
string name, Peripheral *per) {
    list[name] = per;
}
Printer *PrinterList::GetPeripheralByName(string name) {
    return static_cast<Printer *>(
        PeripheralList::GetPeripheralByName(name));
}
int main(int argc, char *argv[])
{
    PrinterList list;
    list.AddPeripheral(string("Koala"),
        new Printer("Koala", Printer::laser,
        150, 105483932)
    );
    list.AddPeripheral(string("Bear"),
        new Printer("Bear", Printer::inkjet,
        80, 5427892)
    );
    Printer *myprinter = list.GetPeripheralByName("Bear");
    if (myprinter != 0) {
        cout << myprinter->Price << endl;
    }
    return 0;
}
