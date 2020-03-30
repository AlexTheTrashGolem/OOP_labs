using System;
using System.Xml.Schema;

namespace OP_laba4_sharp
{
    public class PolarVector
    {
        private double Length { get; set; }
        private double Angle { get; set; }
        
        public PolarVector()
        {
            this.Length = 0;
            this.Angle = 0;
        }

        public PolarVector(double len, double angle)
        {
            this.Length = len;
            this.Angle = angle;
        }

        public PolarVector(PolarVector pv)
        {
            this.Length = pv.Length;
            this.Angle = pv.Angle;
        }

        public double GetLength()
        {
            return this.Length;
        }

        public double GetAngle()
        {
            return this.Angle;
        }

        public void Rotate(double rotation)
        {
            this.Angle += rotation;
        }

        public static PolarVector operator /(PolarVector pv, double divisor)
        {
            pv.Length /= divisor;
            return pv;
        }

        public static PolarVector operator +(PolarVector pv1, PolarVector pv2)
        {
            double x1 = pv1.Length * Math.Cos(pv1.Angle);
            double y1 = pv1.Length * Math.Sin(pv1.Angle);
            
            double x2 = pv2.Length * Math.Cos(pv2.Angle);
            double y2 = pv2.Length * Math.Sin(pv2.Angle);

            double x3 = x1 + x2;
            double y3 = y1 + y2;

            double len3 = Math.Sqrt(x3 * x3 + y3 * y3);
            double ang3 = Math.Atan2(y3, x3);
            
            return new PolarVector(len3, ang3);

        
        }

        public void PrintProperties()
        {
            Console.WriteLine(Convert.ToString(this.Length));
            Console.WriteLine(Convert.ToString(this.Angle));
        }
    }
}