#include <iostream>

using namespace std;

class Simple
{
public:
    int x,y;
    void Write()
    {
        cout << x << " " << y << endl;
    }
    Simple(int startx) { x = startx; }
};

int main()
{
    // This code won't work because there is
    // no default constructor.
    Simple inst;
}
