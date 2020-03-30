#include <iostream>
#include <cmath>
#include <PolarVector.h>

using namespace std;

int main()
{
    PolarVector B1 = PolarVector();
    PolarVector B2 = PolarVector(1.0, 3.14);
    PolarVector B3 = PolarVector(B2);
    B2.PrintProperties();
    B3.PrintProperties();

    B2 = B2/2.0;
    B2.PrintProperties();

    B3.Rotate(3.14/4);
    B3.PrintProperties();

    B1 = B2 + B3;
    B1.PrintProperties();


}
