#include "Expression.h"
#include <math.h>

Expression::Expression(double a, double c, double d) {
    this->_a = a;
    this->_c = c;
    this->_d = d;
}

double Expression::Calculate() {
    if (this->_a == 4) {
        throw "Divide by zero exception. Denominator shouldn`t be equal 0.";
    }
    if (this->_a < 0) {
        throw "Argument Exception. Square root argument should be more than 0";
    }
    double result = (2 * this->_c - this->_d + sqrt(23*this->_a)) / (this->_a/4 - 1);
    return result;
}
