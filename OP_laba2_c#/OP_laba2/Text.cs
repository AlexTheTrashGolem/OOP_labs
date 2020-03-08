using System;

namespace OP_laba2
{
    public class Text
    {
        public MyString[] Value;

        public Text()
        {
            Value = new MyString[0];
        }

        public void AddString(MyString myString)
        {
            Array.Resize(ref Value, Value.Length + 1);
            Value[Value.Length - 1] = myString;
        }

        public void RemoveString(int index)
        {
            var temp = new MyString[Value.Length - 1];
            for(int i = 0; i < Value.Length; i++)
            {
                if (i < index)
                {
                    temp[i] = Value[i];
                } 
                else if (i > index)
                {
                    temp[i-1] = Value[i];
                }
            }
            Value = temp;
        }

        public void ReplaceString(int index, MyString myString)
        {
            Value[index] = myString;
        }

        public void EraseText()
        {
            Value = new MyString[0];
        }

        public int GetLength()
        {
            return Value.Length;
        }

        public string ReturnNumbersOnly()
        {
            string numbers = ""; 
            foreach (MyString myString in Value)
            {
                for (int i = 0; i < myString._length; i++)
                {
                    if (Char.IsDigit(myString.GetChar(i)))
                    {
                        numbers += myString.GetChar(i);
                    } 
                }
            }

            return numbers;
        }
    }
}