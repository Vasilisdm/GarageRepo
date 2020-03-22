using System;

namespace Generics
{
    public class GenericCounter<T>
    {
        private static int value;

        static GenericCounter()
        {
            Console.WriteLine($"Initializing counter for {typeof(T)}");
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine($"Counter for {typeof(T)}: {value}");
        }
    }
}
