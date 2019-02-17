#include <iostream>
#include <vector>
#include <string.h>

using namespace std;

typedef vector<string> StringList;

StringList Split(string orig, string delims)
{
    StringList list;
    int pos;

    while((pos = orig.find_first_of(delims)) != -1)
    {
        list.push_back(orig.substr(0, pos));
        orig = orig.substr(pos + 1);
    }

    list.push_back(orig);

    return list;
}

string MyUppercase(string str)
{
    char *buf = new char[str.length() + 1];

    strcpy(buf, str.c_str());
    strupr(buf);

    return string(buf);
}

string stripspaces(string orig)
{
    int left;
    int right;

    // If string is empty, just return it.
    if (orig.length() == 0)
        return orig;

    // Strip right
    right = orig.find_last_not_of(" \t");
    if (right > -1)
        orig.resize(right + 1);

    // Strip left
    left = orig.find_first_not_of(" \t");
    if (left > -1)
        orig.erase(0, left);

    // If left still has a space, it
    // means the whole string is whitespace.
    // So just remove it all.
    if (orig[0] == ' ' || orig[0] == '\t')
    {
        orig = "";
    }

    return orig;
}
void ProcessName(string name)
{
    StringList list;
    string first, middle, last;
    int size, commapos;
    name = stripspaces(name);
    commapos = name.find(",");

    if (commapos > 0)
    {
        // Name has a comma, so start with last name.
        name.erase(commapos, 1);
        list = Split(name, " ");
        size = list.size();

        if (size > 0)
            last = list[0];
        if (size > 1)
            first = list[1];
        if (size > 2)
            middle = list[2];
    }
    else
    {
        // Name has no comma, so start with first name.
        list = Split(name, " ");
        size = list.size();

        if (size > 0)
            first = list[0];
        if (size > 2)
        {
            middle = list[1];
            last = list[2];
        }
        if (size == 2)
        {
            last = list[1];
        }
    }

    // If middle name is just initial and period,
    // then remove the initial.
    if (middle.length() == 2)
    {
        if (middle[1] == '.')
        {
            middle.erase(1,1);
        }
    }

    // Convert all to uppercase
    first = MyUppercase(first);
    middle = MyUppercase(middle);
    last = MyUppercase(last);

    cout << "first: " << first << endl;
    cout << "middle: " << middle << endl;
    cout << "last: " << last << endl;
    cout << endl;
}

int main()
{
    string name;

    name = "   Washington, George Zeus   ";
    ProcessName(name);

    name = "Washington, George Z.";
    ProcessName(name);

    name = "George Z. Washington";
    ProcessName(name);

    name = "George Zeus Washington";
    ProcessName(name);

    name = "George Washington";
    ProcessName(name);

    return 0;
}
