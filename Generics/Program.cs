using System;
using System.Collections;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            static ArrayList GenerateNames()
            {
                ArrayList names = new ArrayList();
                names.Add("Alpha");
                names.Add("Beta");
                names.Add("Gamma");
                names.Add("Delta");
                names.Add("Epsilon");
                return names;
            }

            static void PrintNames(ArrayList names)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
