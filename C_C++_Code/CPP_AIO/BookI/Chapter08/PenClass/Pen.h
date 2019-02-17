#ifndef PEN_H_INCLUDED
#define PEN_H_INCLUDED

using namespace std;

enum Color
{
    blue,
    red,
    black,
    clear,
    grey
};

enum PenStyle
{
    ballpoint,
    felt_tip,
    fountain_pen
};

class Pen
{
public:
    Color InkColor;
    Color ShellColor;
    Color CapColor;
    PenStyle Style;
    float Length;
    string Brand;
    int InkLevelPercent;

    void write_on_paper(string words)
    {
        if (InkLevelPercent <= 0)
        {
            cout << "Oops! Out of ink!" << endl;
        }
        else
        {
            cout << words << endl;
            InkLevelPercent = InkLevelPercent - words.length();
        }
    }

    void break_in_half()
    {
        InkLevelPercent = InkLevelPercent / 2;
        Length = Length / 2.0;
    }

    void run_out_of_ink()
    {
        InkLevelPercent = 0;
    }
};

#endif // PEN_H_INCLUDED
