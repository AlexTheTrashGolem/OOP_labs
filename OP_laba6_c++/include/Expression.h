#ifndef EXPRESSION_H
#define EXPRESSION_H


class Expression {
    private:
        double _a, _c, _d;
    public:
        Expression(double, double, double);
        double Calculate();
};

#endif // EXPRESSION_H
