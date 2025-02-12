using System.Collections;
namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("hello");
            list.Add(5);

            foreach (object v in list)
            {
                if (v is int)
                {
                    int x = (int)v;
                    Console.WriteLine(x);
                }
                else if (v is string)
                {
                    string s = (string)v;
                    Console.WriteLine(s);
                }
            }
        }
    }
}
