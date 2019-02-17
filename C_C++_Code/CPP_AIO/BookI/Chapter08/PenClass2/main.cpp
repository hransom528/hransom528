#include <iostream>
#include "Pen.h"

using namespace std;

int main()
{
  Pen FavoritePen;

  FavoritePen.InkColor = blue;
  FavoritePen.ShellColor = grey;
  FavoritePen.CapColor = blue;
  FavoritePen.Style = ballpoint;
  FavoritePen.Length = 5.5;
  FavoritePen.Brand = "Office Depot";
  FavoritePen.InkLevelPercent = 30;

  Pen WorstPen;

  WorstPen.InkColor = red;
  WorstPen.ShellColor = red;
  WorstPen.CapColor = black;
  WorstPen.Style = fountain_pen;
  WorstPen.Length = 5.0;
  WorstPen.Brand = "Parker";
  WorstPen.InkLevelPercent = 60;

  cout << "This is my favorite pen" << endl;
  cout << "Color: " << FavoritePen.InkColor << endl;
  cout << "Brand: " << FavoritePen.Brand << endl;
  cout << "Ink Level: " << FavoritePen.InkLevelPercent << "%" << endl;

  FavoritePen.write_on_paper("Hello I am a pen");
  cout << "Ink Level: " << FavoritePen.InkLevelPercent << "%" << endl;

  return 0;
}
