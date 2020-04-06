#include "Segment.h"

Segment::Segment()
{
}

Segment::Segment(Dot first, Dot second)
{
    start = first;
    finish = second;
    dx = start.x - finish.x;
    dy = start.y - finish.y;
}

double Segment::GetAngle()
{
    double cosine = (0*dx + 1*dy)/(GetLength()*1);
    return acos(cosine);
}

Dot Segment::GetStart()
{
    return start;
}

Dot Segment::GetEnd()
{
    return finish;
}

void Segment::Print()
{
    cout<<"Start: "<<start.x<<","<<start.y<<endl;
    cout<<"Finish: "<<finish.x<<","<<finish.y<<endl;
    cout<<"Length: "<<GetLength()<<endl;
    cout<<"Angle with OY: "<<GetAngle()<<endl;
}
