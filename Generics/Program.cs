using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(1);
            numbers.Add(7);

            List<int> firstTwo = CopyAtMost(numbers, 2);
            Console.WriteLine($"The first 2 elements of the numbers list copied, to FirstTwo list");

            foreach (int number in firstTwo)
            {
                Console.WriteLine($"{number}");
            }
        }


        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> ret = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }

            return ret;
        }
    }
}
