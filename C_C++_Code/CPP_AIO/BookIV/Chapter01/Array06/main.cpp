#include <iostream>

using namespace std;

int main()
{
    // Both of these array forms produce an error.

    // Non-constant array form.
    int NonConstant[5] = { 1, 2, 3, 4, 5 };
    int OtherList[5] = { 10, 11, 12, 13, 14 };
    OtherList = NonConstant;

    // Constant array form.
//    const int NonConstant[5] = { 1, 2, 3, 4, 5 };
//    const int OtherList[5] = { 10, 11, 12, 13, 14 };
//    OtherList = NonConstant;

}
