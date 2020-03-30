using System;
namespace OP_laba4_sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PolarVector B1 = new PolarVector();
            PolarVector B2 = new PolarVector(1, Math.PI);
            PolarVector B3 = new PolarVector(B2);
            B3.PrintProperties();

            B2 /= 2;
            B2.PrintProperties();
            B3.Rotate(Math.PI/4);
            B3.PrintProperties();
            B1 = B2 + B3;
            B1.PrintProperties();
            
            

        }
    }
}