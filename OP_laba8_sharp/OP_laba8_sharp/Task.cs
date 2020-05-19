using System;

namespace OP_laba8_sharp
{
    public static class Task
    {
        public delegate void ArrayOperation(int[] ls);

        public static void SortByAscending(int[] ls) => Array.Sort(ls);
        
        public static void PrintArray(int[] ls)
        {
            foreach (var c in ls)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}