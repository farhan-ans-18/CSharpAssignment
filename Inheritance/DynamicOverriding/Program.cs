namespace DynamicOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    abstract class Shape
    {
        public abstract void Area();
    }

    class Rectangle : Shape
    {
        public  void Area()
        {

        }
    }
}
