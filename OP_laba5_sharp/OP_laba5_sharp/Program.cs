using System;

namespace OP_laba5_sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dot s = new Dot(0, 0);
            Dot e = new Dot(-1, 0);
            Segment mySegment = new Segment(s, e);
            Console.WriteLine("Start:({0},{1})", mySegment.GetStart().X, mySegment.GetStart().Y);
            Console.WriteLine("End:({0},{1})", mySegment.GetEnd().X, mySegment.GetEnd().Y);
            Console.WriteLine("Length:{0}", mySegment.GetLength());
            Console.WriteLine("Angle with OY: {0}", mySegment.AngleWithOY());
        }
    }
}