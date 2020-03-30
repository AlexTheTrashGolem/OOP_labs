#include "PolarVector.h"


PolarVector::PolarVector()
{
    Length = 0.0;
    Angle = 0.0;
}

PolarVector::PolarVector(double len, double angle)
{
    Length = len;
    Angle = angle;
}

PolarVector::PolarVector(const PolarVector &pv)
{
    Length = pv.Length;
    Angle = pv.Angle;
}

void PolarVector::Rotate(double rotation)
{
    Angle += rotation;
}

double PolarVector::GetLength()
{
    return Length;
}

double PolarVector::GetAngle()
{
    return Angle;
}

PolarVector PolarVector::operator/(double divisor)
{
    Length /= divisor;
    return PolarVector(Length, Angle);
}

PolarVector PolarVector::operator+(PolarVector const &pv)
{

  double x1 = Length * cos(Angle);
  double y1 = Length * sin(Angle);
  double x2 = pv.Length * cos(pv.Angle);
  double y2 = pv.Length * sin(pv.Angle);

  double x3 = x2 - x1;
  double y3 = y2 - y1;

  double len3 = sqrt(x3*x3 + y3*y3);
  double angle3 = atan2(y3, x3);

  return PolarVector(len3, angle3);
}

void PolarVector::PrintProperties()
{
    std::cout << Length << std::endl;
    std::cout << Angle << std::endl;
}
