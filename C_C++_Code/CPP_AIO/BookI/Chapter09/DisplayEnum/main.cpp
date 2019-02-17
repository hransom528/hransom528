#include <iostream>

using namespace std;

class Colors
{
public:
    enum ColorEnum {blue, red, green, yellow, black};
    Colors(Colors::ColorEnum value);
    string AsString();

protected:
   ColorEnum value;
};

Colors::Colors(Colors::ColorEnum initvalue)
{
    value = initvalue;
}

string Colors::AsString()
{
    switch (value)
    {
    case blue:
        return "blue";
    case red:
        return "red";
    case green:
        return "green";
    case yellow:
        return "yellow";
    case black:
        return "black";
    default:
        return "Not Found";
    }
}

int main()
{
    Colors InkColor = Colors::red;
    cout << InkColor.AsString() << endl;
    return 0;
}
