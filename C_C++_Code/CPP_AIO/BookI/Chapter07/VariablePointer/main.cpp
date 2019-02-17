#include <iostream>

using namespace std;

void ChangesAreGood(int myparam)
{
    myparam += 10;
    cout << "Inside the function:" << endl;
    cout << myparam << endl;
}

int main()
{
  int mynumber = 30;
  cout << "Before the function:" << endl;
  cout << mynumber << endl;

  ChangesAreGood(mynumber);
  cout << "After the function:" << endl;
  cout << mynumber << endl;

  return 0;
}
