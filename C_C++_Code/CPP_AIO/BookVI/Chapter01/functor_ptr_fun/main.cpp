#include <iostream>
#include <math.h>
#include <ext/functional>
#include <algorithm>

using namespace std;
using namespace __gnu_cxx;

int main()
{
    const int N = 10;
    double A[N];
    fill(A, A+N, 100);

    cout << A[0] << endl;

    transform(A, A+N, A, compose1(negate<double>(), ptr_fun(fabs)));

    cout << A[0] << endl;

    return 0;
}
