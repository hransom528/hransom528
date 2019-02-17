#include <iostream>

using namespace std;

class FinalType {};
class AnotherType : public FinalType {};

int main()
{
    AnotherType *orig = new AnotherType;
    FinalType *f = static_cast<FinalType *>(orig);
}
