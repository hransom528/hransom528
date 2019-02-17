#include <iostream>

using namespace std;

int AddOne(int start)
{
  int newnumber;
  newnumber = start + 1;
  return newnumber;
}

int main()
{
  int testnumber;
  int result;

  testnumber = 20;
  result = AddOne(testnumber);

  cout << result << endl;
  return 0;
}
