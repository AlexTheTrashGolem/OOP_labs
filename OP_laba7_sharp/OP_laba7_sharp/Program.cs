
namespace OP_laba7_sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OneSideLinkedList mylist = new OneSideLinkedList();
            mylist.PushForward('!');            
            mylist.PushForward('a');
            mylist.PushForward('i');
            mylist.PushForward('1');
            mylist.Print();
            System.Console.WriteLine(mylist.FirstExclamation());
            mylist.RemoveA();
            mylist.Print();
            System.Console.WriteLine(mylist.FirstExclamation());
        }
    }
}