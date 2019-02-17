#include <iostream>

using namespace std;

template<typename T>
struct Volume
{
    T height;
    T width;
    T length;

    Volume()
    {
        height = 0;
        width = 0;
        length = 0;
    }

    T getvolume()
    {
        return height * width * length;
    }

    T getvolume(T H, T W, T L)
    {
        height = H;
        width = W;
        length = L;

        return height * width * length;
    }

};

int main()
{
    Volume<int> first;

    cout << "First volume: " << first.getvolume() << endl;

    first.height = 2;
    first.width = 3;
    first.length = 4;

    cout << "First volume: " << first.getvolume() << endl;

    Volume<double> second;

    cout << "Second volume: " << second.getvolume(2.1, 3.2, 4.3) << endl;
    cout << "Height: " << second.height << endl;
    cout << "Width: " << second.width << endl;
    cout << "Length: " << second.length << endl;

    return 0;
}
