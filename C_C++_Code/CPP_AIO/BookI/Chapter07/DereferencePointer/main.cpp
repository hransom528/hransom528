#include <iostream>

using namespace std;

int main()
{
  int NumberOfPotholes;
  int *ptr;
  ptr = &NumberOfPotholes;
  *ptr = 6087;
  cout << NumberOfPotholes << endl;
  return 0;
}
