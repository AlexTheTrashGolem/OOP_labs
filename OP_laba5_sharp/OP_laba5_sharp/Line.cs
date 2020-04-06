using System;

namespace OP_laba5_sharp
{
    public class Line
    {
        protected Dot _start;
        protected Dot _end;
        protected double dx;
        protected double dy;
    
        
        public Line()
        {
            this._start = null;
            this._end = null;
            dx = 0;
            dy = 0;
        }
        
        public Line(Dot start, Dot end)
        {
            this._start = start;
            this._end = end;
            dx = _end.X - _start.X;
            dy = _end.Y - _start.Y;
        }

        public double GetLength()
        {
            return Math.Sqrt(dx * dx + dy * dy);
        }
        
        
        
    }
}