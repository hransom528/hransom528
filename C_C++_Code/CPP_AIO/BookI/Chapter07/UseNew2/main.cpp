#include <iostream>

using namespace std;

int main()
{
  string *Password = new string;
  *Password = "The egg salad is not fresh.";
  cout << *Password << endl;
  return 0;
}
