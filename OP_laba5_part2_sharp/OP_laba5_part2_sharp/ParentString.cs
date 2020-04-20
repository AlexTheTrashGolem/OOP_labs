using System;

namespace OP_laba5_part2_sharp
{
    public class ParentString
    {
        protected char[] StrValue { get; set; }

        public ParentString(params char[] str)
        {
            StrValue = str;
        }
        
        //Методи отримання довжини та значень не віртуальні бо не має сенсу
        public int GetLength() => StrValue.Length;
        public char[] GetValue() => StrValue;

        public virtual void Sort() {}
        
    }
}