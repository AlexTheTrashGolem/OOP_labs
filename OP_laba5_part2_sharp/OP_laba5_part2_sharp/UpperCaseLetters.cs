using System;
using System.Linq;
    
namespace OP_laba5_part2_sharp
{
    public class UpperCaseLetters : ParentString
    {
        public UpperCaseLetters(params char[] str) : base()
        {
            if (!str.All(Char.IsUpper))
            {
                throw new Exception("String should only contain capital letters!");
            }
        }
        public override void Sort()
        {
            Array.Sort(StrValue);
        }
    }
}