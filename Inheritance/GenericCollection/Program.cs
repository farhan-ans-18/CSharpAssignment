namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
