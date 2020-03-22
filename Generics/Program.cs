namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }
    }
}
