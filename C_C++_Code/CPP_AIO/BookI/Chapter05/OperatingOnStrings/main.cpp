#include <iostream>

using namespace std;

int main()
{
  string words = "Something interesting and bizarre";
  cout << words << endl;

  words.insert(10, "seriously ");
  cout << words << endl;

  words.erase(19,16);
  cout << words << endl;

  words.replace(4, 5, "body");
  cout << words << endl;

  return 0;
}
