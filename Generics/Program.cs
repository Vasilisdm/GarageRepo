using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            static List<string> GenerateNames()
            {
                List<string> names = new List<string>();
                names.Add("Alpha");
                names.Add("Beta");
                names.Add("Gamma");
                names.Add("Delta");
                names.Add("Epsilon");
                return names;
            }

            static void PrintNames(List<string> names)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
