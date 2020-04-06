using System;

namespace OP_laba5_sharp
{
    public class Segment : Line
    {
        public Segment(Dot start, Dot end) 
            :base(start, end)
        {
        }
        
        public Dot GetStart()
        {
            return _start;
        }
        
        public Dot GetEnd()
        {
            return _end;
        }
        
        public double AngleWithOY()
        {
            double cosa = (dx * 1 + dy * 0)/(this.GetLength() * 1);
            return Math.Acos(cosa);
        }
    }
}