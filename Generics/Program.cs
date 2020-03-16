using System;
using System.Collections.Specialized;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            static StringCollection GenerateNames()
            {
                StringCollection names = new StringCollection();
                names.Add("Alpha");
                names.Add("Beta");
                names.Add("Gamma");
                names.Add("Delta");
                names.Add("Epsilon");
                return names;
            }

            static void PrintNames(StringCollection names)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
