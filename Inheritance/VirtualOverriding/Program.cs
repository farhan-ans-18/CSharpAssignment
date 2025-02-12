namespace VirtualOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           College1 c1 = new College1();
            c1.GetResult(55);
            College2 c2 = new College2();
            c2.GetResult(70);
        }
    }

    class University
    {
        public virtual void GetResult(int marks)
        {
     
            if(marks >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }

    class College1 : University
    {

    }

    class College2 : University
    {
        public override void GetResult(int marks)
        {
            if (marks >= 70)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
