using System;

namespace OP_laba3_sharp
{
    public class MyArray
    {
        private int[] _value;

        private int Length
        {
            get { return _value.Length; }
        }
        
        
        public MyArray(int length)
        {
            _value = new int[length];
        }
        
        

        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    Console.WriteLine("An error occured: Index is out of range.");
                    return -1;
                }
                else
                {
                    return _value[index];
                }
            }

            set
            {
                if (index >= Length || index < 0)
                {
                    Console.WriteLine("An error occured: Index is out of range.");
                }
                else
                {
                    _value[index] = value;
                }
            }
        }
    }
}