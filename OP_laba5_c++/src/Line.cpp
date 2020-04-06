#include "Line.h"

Line::Line()
{
    start = Dot(0.0,0.0);
    finish = Dot(0.0, 0.0);
    dx = 0.0;
    dy = 0.0;
}

Line::Line(Dot first, Dot second)
{
    start = first;
    finish = second;
    dx = start.x - finish.x;
    dy = start.y - finish.y;
}

double Line::GetLength()
{
    return sqrt(dx*dx - dy*dy);
}
