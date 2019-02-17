#include <iostream>

using namespace std;

string Paranoid(const string *realmessage)
{
  string NewString = *realmessage;
  NewString[6] = 'i';
  NewString.replace(9, 1, "");
  NewString.insert(18, "ad");
  NewString.replace(15, 2, "in");
  NewString.replace(23, 7, "!");
  NewString.replace(4, 3, "ali");

  return NewString;
}

int main()
{
  string message = "The friends are having dinner";
  cout << message << endl;

  string NewMessage = Paranoid(&message);
  cout << NewMessage << endl;

  return 0;
}
