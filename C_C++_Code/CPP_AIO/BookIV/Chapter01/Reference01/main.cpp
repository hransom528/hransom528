#include <iostream>

using namespace std;

int main()
{
    int ImSomebody;
    int &BestReference = ImSomebody;
    BestReference = 10;
    cout << ImSomebody << endl;
}
