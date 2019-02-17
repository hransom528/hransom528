#include <iostream>

using namespace std;

void PrintName(string first, string last)
{
  string fullname = first + " " + last;
  cout << fullname << endl;
}

int main()
{
  PrintName("Thomas", "Jefferson");
  return 0;
}
