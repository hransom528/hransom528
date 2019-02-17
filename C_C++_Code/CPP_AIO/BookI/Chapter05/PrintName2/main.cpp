#include <iostream>

using namespace std;

void PrintName(string first, string last);

int main()
{
  PrintName("Thomas", "Jefferson");
  return 0;
}

void PrintName(string first, string last)
{
  string fullname = first + " " + last;
  cout << fullname << endl;
}
