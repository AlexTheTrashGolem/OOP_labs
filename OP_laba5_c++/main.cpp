#include <iostream>
#include <Segment.h>
#include <Dot.h>
using namespace std;

int main()
{
    Dot start = Dot(0.0, 0.0);
    Dot fin = Dot(1.0, 0.0);
    Segment mySeg = Segment(start, fin);

    mySeg.Print();
}
