#ifndef LINE_H
#define LINE_H
#include <cmath>
#include <Dot.h>

class Line
{
    public:
        Line();
        Line(Dot first, Dot second);
        double GetLength();
    protected:
        Dot start;
        Dot finish;
        double dx;
        double dy;

    private:
};

#endif // LINE_H
