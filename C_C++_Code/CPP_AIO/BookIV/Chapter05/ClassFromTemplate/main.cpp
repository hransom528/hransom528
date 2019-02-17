#include <iostream>

using namespace std;

class Book
{
public:
    string Name;
    string Author;
    string Publisher;
    Book(string aname, string anauthor, string apublisher) :
        Name(aname), Author(anauthor), Publisher(apublisher)
        {}
};

class Magazine
{
public:
    string Name;
    string Issue;
    string Publisher;
    Magazine(string aname, string anissue,
        string apublisher) :
        Name(aname), Issue(anissue), Publisher(apublisher)
        {}
};

template <typename T>
class MediaHolder
{
public:
    T *array[100];
    int Count;

    void Add(T *item)
    {
        array[Count] = item;
        Count++;
    }

    MediaHolder() : Count(0) {}
};

class BookHolder : public MediaHolder<Book> {
public:
    enum GenreEnum
        {childrens, scifi, romance,
         horror, mainstream, hownotto};

    GenreEnum GenreOfAllBooks;
};

class MagazineHolder : public MediaHolder<Magazine>
{
public:
    bool CompleteSet;
};

int main()
{
    MagazineHolder dl;
    dl.Add(new Magazine(
        "Dummies Life", "Vol 1 No 1", "Wile E."));
    dl.Add(new Magazine(
        "Dummies Life", "Vol 1 No 2", "Wile E."));
    dl.Add(new Magazine(
        "Dummies Life", "Vol 1 No 3", "Wile E."));
    dl.CompleteSet = false;
    cout << dl.Count << endl;

    BookHolder bh;
    bh.Add(new Book(
        "CEOing for Dumdums", "Gookie Dan", "Wile E."));
    bh.Add(new Book(
        "Carsmashing for Dumdums", "Woodie and Buzz",
        "Wile E."));
    bh.Add(new Book(
        "Turning off the Computer for Dumdums",
        "Wrath of Andy",
        "Wile E."));
    bh.GenreOfAllBooks = BookHolder::hownotto;
    cout << bh.Count << endl;

    return 0;
}
