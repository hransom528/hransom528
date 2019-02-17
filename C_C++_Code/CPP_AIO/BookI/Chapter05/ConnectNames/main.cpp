#include <iostream>

using namespace std;

string ConnectNames(string first, string last)
{
  return first + " " + last;
}

int main()
{
  cout << ConnectNames("Richard", "Nixon") << endl;
  return 0;
}
