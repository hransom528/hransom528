#include <iostream>
#include <cstdlib>

using namespace std;

class BrokenMirror
{
private:
    int NumberOfPieces;

public:
    int GetNumberOfPieces();
    void SetNumberOfPieces(int newamount);
    BrokenMirror() : NumberOfPieces(100) {}
};

int BrokenMirror::GetNumberOfPieces()
{
    return NumberOfPieces;
}

void BrokenMirror::SetNumberOfPieces(int newamount)
{
    newamount = newamount * 20;
    NumberOfPieces = newamount;
}

int SpecialMath(int x)
{
    return x * 10 - 5;
}

int main()
{
    int i = 10;
    BrokenMirror mirror;

    i = i + SpecialMath(i);

    mirror.SetNumberOfPieces(i);
    cout << mirror.GetNumberOfPieces() << endl;

    // Clear this comment if you want the application to stop to
    // display the results.
    // system("PAUSE");

    return 0;
}
