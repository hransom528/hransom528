#include <iostream>

using namespace std;

int main()
{
  string *phrase = new string("All presidents are cool!!!");
  cout << *phrase << endl;

  (*phrase)[20] = 'r';
  phrase->replace(22, 4, "oked");
  cout << *phrase << endl;

  delete phrase;
  return 0;
}
