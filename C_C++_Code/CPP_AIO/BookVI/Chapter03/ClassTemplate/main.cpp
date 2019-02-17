#include <iostream>
#include <vector>

using namespace std;

template<typename T>
class MyQueue
{
protected:
    vector<T> data;

public:
    void Add(T const &input);
    void Remove();
    void PrintString();
    void PrintInt();
    bool IsEmpty();
};

template<typename T>
void MyQueue<T>::Add(T const &input)
{
    data.push_back(input);
}

template<typename T>
void MyQueue<T>::Remove()
{
    data.erase(data.begin());
}

template<typename T>
void MyQueue<T>::PrintString()
{
    vector<string>::iterator PrintIt = data.begin();

    while (PrintIt != data.end())
    {
        cout << *PrintIt << endl;
        PrintIt++;
    }
}

template<typename T>
void MyQueue<T>::PrintInt()
{
    vector<int>::iterator PrintIt = data.begin();

    while (PrintIt != data.end())
    {
        cout << *PrintIt << endl;
        PrintIt++;
    }
}

template<typename T>
bool MyQueue<T>::IsEmpty()
{
    return data.begin() == data.end();
}

int main()
{
    MyQueue<string> StringQueue;

    cout << StringQueue.IsEmpty() << endl;

    StringQueue.Add("Hello");
    StringQueue.Add("Goodbye");

    cout << "Printing strings: " << endl;
    StringQueue.PrintString();
    cout << StringQueue.IsEmpty() << endl;

    StringQueue.Remove();
    cout << "Printing strings: " << endl;
    StringQueue.PrintString();
    StringQueue.Remove();
    cout << StringQueue.IsEmpty() << endl;

    MyQueue<int> IntQueue;

    IntQueue.Add(1);
    IntQueue.Add(2);

    cout << "Printing ints: " << endl;
    IntQueue.PrintInt();

    return 0;
}
