using System;
using System.Linq;

namespace OP_laba1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Increment(31); // result is 32
            Increment(56); // result is 57
            Increment(-25); // result is-24
            IsGreater(44, 44); // result is false
            IsGreater(46, -7); // result is true
            IsGreater(15, 30); // result is false
        }

        private static int Increment(int number) 
        {
            return -~number;
        }

        private static void ArgIncrement(int number, out int result)
        {
            result = -~number;
        }

        private static int Addition(int number1, int number2)
        {
            while (number2 != 0)
            {
                var carry = number1 & number2;
                number1 ^= number2;
                number2 = carry << 1;
            }

            return number1;
        }

        private static bool IsGreater(int number1, int number2)
        {
            if ((number1 ^ number2) == 0)
            {
                return false;
            }
            var sign = Addition(number1, Addition(~number2, 1)) >> 31;
            return sign == 0;
        }

        private static void ArgIsGreater(int number1, int number2, ref bool result)
        {
            if ((number1 ^ number2) == 0)
            {
                result = false;
                return;
            }
            var sign = Addition(number1, Addition(~number2, 1)) >> 31;
            result = Convert.ToBoolean(sign == 0);
        }
    }
}
