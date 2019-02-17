#include <iostream>

using namespace std;

int main()
{
  string HorribleMovie;
  string *ptrToString;

  HorribleMovie = "L.A. Confidential";
  ptrToString = &HorribleMovie;

  for (unsigned i = 0; i < HorribleMovie.length(); i++)
  {
    cout << (*ptrToString)[i] << " ";
  }

  cout << endl;
  return 0;
}
