using System;
using System.Linq;
using System.Net.Cache;

namespace OP_laba5_part2_sharp
{
    public class LowerCaseLetters : ParentString
    {
        
        public LowerCaseLetters(params char[] str) : base()
        {
            if (!str.All(Char.IsLower))
            {
                throw new Exception("String should only contain lowercase letters!");
            }
        }

        public override void Sort() 
        {
            base.Sort();
            Array.Reverse(StrValue);
        }
    }
}