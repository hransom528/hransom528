#include <iostream>
#include "Pen.h"

using namespace std;

void Inspect(const Pen *Checkitout)
{
    cout << Checkitout->Brand << endl;
}

int main()
{
    Pen *MyPen = new Pen();
    MyPen->Brand = "Spy Plus Camera";

    Inspect(MyPen);

    return 0;
}
