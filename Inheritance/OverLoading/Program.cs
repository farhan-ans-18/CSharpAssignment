namespace OverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Demo.Add(4, 3));
            Console.WriteLine(Demo.Add(5, 2));
        }
    }

    class Demo
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
}
