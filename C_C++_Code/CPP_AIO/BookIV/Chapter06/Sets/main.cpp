#include <iostream>
#include <set>

using namespace std;

class Employee
{
public:
    string Nickname;
    string SocialSecurityNumber;

    Employee(string anickname, string asocial) :
        Nickname(anickname),
        SocialSecurityNumber(asocial) {}

    Employee() : Nickname(""), SocialSecurityNumber("") {}
};

bool operator < (const Employee& first,
const Employee& second)
{
    return first.SocialSecurityNumber <
        second.SocialSecurityNumber;
}

ostream& operator << (ostream &out, const Employee &emp)
{
    cout << "(" << emp.Nickname;
    cout << "," << emp.SocialSecurityNumber;
    cout << ")";
    return out;
}

int main()
{
    set<Employee> employees;

    Employee emp1("sparky", "123-22-8572");
    employees.insert(emp1);

    Employee emp2("buzz", "234-33-5784");
    employees.insert(emp2);

    Employee emp3("coollie", "123-22-8572");
    employees.insert(emp3);

    Employee emp4("sputz", "199-19-0000");
    employees.insert(emp4);

    // List the items
    set<Employee>::iterator iter = employees.begin();
    while (iter != employees.end())
    {
        cout << *iter << endl;
        iter++;
    }

    // Find an item
    cout << "Finding..." << endl;
    Employee findemp("", "123-22-8572");

    iter = employees.find(findemp);
    cout << *iter << endl;

    return 0;
}
