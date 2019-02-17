#include <iostream>
#include "Pen.h"

using namespace std;

int main()
{
    Pen *MyPen;
    MyPen = new Pen;

    MyPen->InkColor = red;
    cout << MyPen->InkColor << endl;

    delete MyPen;
    MyPen = 0;

    return 0;
}
