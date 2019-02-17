#include <iostream>

using namespace std;

int main()
{
  int *ptr = new int;
  *ptr = 10;
  cout << *ptr << endl;
  return 0;
}
