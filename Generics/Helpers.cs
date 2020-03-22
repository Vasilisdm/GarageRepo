using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    public class Helpers
    {
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


        public static void PrintType<T>()
        {
            Console.WriteLine($"{typeof(T)}");
            Console.WriteLine($"{typeof(List<T>)}");
        }
    }
}
