#ifndef POLARVECTOR_H
#define POLARVECTOR_H
#include <cmath>
#include <iostream>


class PolarVector
{
    public:
        PolarVector();
        PolarVector(const PolarVector&);
        PolarVector(double len, double angle);
        void Rotate(double);
        double GetLength();
        double GetAngle();
        PolarVector operator /(double divisor);
        PolarVector operator +(PolarVector const &pv);
        void PrintProperties();

    protected:

    private:
        double Length;
        double Angle;
};

#endif // POLARVECTOR_H
