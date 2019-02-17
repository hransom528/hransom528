#include <iostream>

using namespace std;

void MessMeUp(int &myparam)
{
  myparam = myparam * 2 + 10;
}

int main()
{
  int mynumber = 30;
  MessMeUp(mynumber);
  cout << mynumber << endl;
  return 0;
}
