#include <iostream>

using namespace std;

void Combine(string first, string second)
{
  cout << first << " " << second << endl;
}

void Combine(int first, int second)
{
  int sum = first + second;
  cout << first << " " << second << " " << sum << endl;
}

int main()
{
  Combine("David","Letterman");
  Combine(15,20);
  return 0;
}
