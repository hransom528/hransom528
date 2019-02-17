#include <iostream>

using namespace std;

int main()
{
  int ExpensiveComputer;
  int CheapComputer;
  int *ptrToComp;

  ptrToComp = &ExpensiveComputer;
  *ptrToComp = 2000;
  cout << *ptrToComp << endl;

  ptrToComp = &CheapComputer;
  *ptrToComp = 500;
  cout << *ptrToComp << endl;

  ptrToComp = &ExpensiveComputer;
  cout << *ptrToComp << endl;
  return 0;
}
