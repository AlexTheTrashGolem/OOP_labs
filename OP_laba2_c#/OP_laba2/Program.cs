using System;

namespace OP_laba2
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      char[] s = {'a', 'b', 'c', '1'};
      MyString str = new MyString(s);
      Text txt = new Text();
      txt.AddString(str);
      Console.WriteLine(txt.ReturnNumbersOnly());
    }
  }
}