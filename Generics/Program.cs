using System;

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int? noValue = new int?();
            object noValueBoxed = noValue;
            Console.WriteLine($"The boxed value is null: {noValueBoxed == null}");

            int? someValue = new int?(5);
            object someValueBoxed = someValue;
            Console.WriteLine($"The boxed value is not null and has a type of :{someValueBoxed.GetType()}");
        }
    }
}
