#include <iostream>
#include <cstdlib>

using namespace std;

int CountRabbits(int original)
{
    int result = original * 2;
    result = result + 10;
    result = result * 4;
    cout << "Calculating " << result << endl;
    return result * 10;
}

int CountAntelopes(int original)
{
    int result = original + 10;
    result = result - 2;
    cout << "Calculating " << result << endl;
    return result;
}

int main()
{
    int rabbits = 5;
    int antelopes = 5;
    rabbits = CountRabbits(rabbits);
    cout << "Rabbits now at " << rabbits << endl;
    antelopes = CountAntelopes(antelopes);
    cout << "Antelopes now at " << antelopes << endl;
    //system("PAUSE"); // add this for Windows
    return 0;
}
