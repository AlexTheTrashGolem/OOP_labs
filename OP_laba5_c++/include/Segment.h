#ifndef SEGMENT_H
#define SEGMENT_H
#include <Line.h>
#include <iostream>
using namespace std;

class Segment : public Line
{
    public:
        Segment();
        Segment(Dot first, Dot second);
        double GetAngle();
        void Print();
        Dot GetStart();
        Dot GetEnd();

    protected:

    private:
};

#endif // SEGMENT_H
