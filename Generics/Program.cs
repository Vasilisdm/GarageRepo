using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;

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


        public static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
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


        public static T LastOrDefault<T>(IEnumerable<T> source)
        {
            T ret = default(T);

            foreach (T item in source)
            {
                ret = item;
            }

            return ret;
        }
    }
}
