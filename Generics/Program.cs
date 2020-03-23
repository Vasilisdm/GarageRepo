using System;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // If I use the GetType on noValue it throws a null reference.
            //int? noValue = new int?();

            int? someValue = new int?(5);
            Console.WriteLine($"The type of someValue is: {someValue.GetType()}");
        }
    }
}
