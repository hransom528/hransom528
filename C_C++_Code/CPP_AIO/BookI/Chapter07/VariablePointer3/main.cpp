#include <iostream>

using namespace std;

void Paranoid(string *realmessage)
{
  (*realmessage)[6] = 'i';
  realmessage->replace(9, 1, "");
  realmessage->insert(18, "ad");
  realmessage->replace(15, 2, "in");
  realmessage->replace(23, 7, "!");
  realmessage->replace(4, 3, "ali");
}

int main()
{
  string message = "The friends are having dinner";
  cout << message << endl;

  Paranoid(&message);
  cout << message << endl;

  return 0;
}
