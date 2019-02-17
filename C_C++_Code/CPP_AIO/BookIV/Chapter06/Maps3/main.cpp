#include <iostream>
#include <map>

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

class Salary
{
public:
    int AnnualRipoff;
    int IRSDeductionsCheat;

    Salary(int aannual, int adeductions) :
        AnnualRipoff(aannual),
        IRSDeductionsCheat(adeductions) {}

    Salary() : AnnualRipoff(0), IRSDeductionsCheat(0) {}
};

bool operator < (const Employee& first, const Employee& second)
{
    return first.Nickname < second.Nickname;
}

int main()
{
    map<Employee, Salary> employees;

    Employee emp1("sparky", "123-22-8572");
    Salary sal1(135000, 18);
    employees[emp1] = sal1;

    Employee emp2("buzz", "234-33-5784");
    Salary sal2(150000, 23);
    employees[emp2] = sal2;

    // Now test it out!
    Employee emptest("sparky", "");
    cout << employees[emptest].AnnualRipoff << endl;

    return 0;
}
