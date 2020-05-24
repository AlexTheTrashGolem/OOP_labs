using System;

namespace OP_laba8_sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[]{53, 44, 36, 97};
            Task.ArrayOperation sortByAscending = Task.SortByAscending;
            sortByAscending += Task.PrintArray;
            sortByAscending(arr);
            
            
            Car car2 = new Car(100, 10);
            car2.Notify += ActionHandler;
            car2.StartMoving();
            car2.Move(15);
            car2.RefillTank();
            car2.StartMoving();
            car2.Move(5);
        }

        private static void ActionHandler(ActionHandlerArgs handlerArgs)
        {
            Console.WriteLine(handlerArgs.Message);
        }
    }
}
