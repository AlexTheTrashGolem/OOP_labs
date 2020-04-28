using System;


namespace OP_laba6_sharp
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var array = new Expression[3]
            {
                new Expression(92.0, 0.0, 24.0),
                new Expression(-1.0, 0.0, 24.0),
                new Expression(4.0, 0.0, 24.0),
            };
            foreach (var expression in array)
            {
                {
                    var result = expression.Calculate();
                    Console.WriteLine($"Result: {result}");
                }

            }

        }
    }
}