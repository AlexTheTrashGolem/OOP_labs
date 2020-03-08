namespace OP_laba2
{
    public class MyString
    {
        private char[] Value;
        public int _length;
        
        public MyString(char[] txt)
        {
            this.Value = txt;
            this._length = this.Value.Length;
        }

        public char GetChar(int index)
        {
            return Value[index];
        }
        
    }
}