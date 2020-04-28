using System;

namespace OP_laba6_sharp
{
    public class Expression
    {
        private double A { get; set; }
        private double C { get; set; }
        private double D { get; set; }

        public Expression(double a, double c, double d)
        {    
            A = a;
            C = c;
            D = d;
        }

        public double Calculate()
        {
            
            if (A < 0 )
            {
                throw new ArithmeticException("Incorrect square root argument.");
            } 
            if (A == 4) 
            {
                throw new DivideByZeroException("Denominator shouldn`t be equal 0.");
            }
            double result = (2 * C - D + Math.Sqrt(23 * A)) / (A / 4 - 1); 
            return result;
        }

    }
}