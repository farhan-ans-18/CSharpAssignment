namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John Doe", "Bangalore", 90);
            student.Display();
            student.IsOutStanding();

            Faculty faculty = new Faculty("Ramnath", "Bangalore", 6);
            faculty.Display();
            faculty.IsOutStanding();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Person(string name, string city)
        {
            Name = name;
            City = city;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name} and City: {City}");
        }
    }

    public class Student : Person
    {
        public int TotalMarks { get; set; }

        public Student(string name, string city, int totalMarks)
            : base(name, city)
        {
            TotalMarks = totalMarks;
        }

        public void IsOutStanding()
        {
            if (TotalMarks >= 90)
            {
                Console.WriteLine("Outstanding");
            }
            else
            {
                Console.WriteLine("Not oustanding");
            }
        }
        public void Display()
        {
            //base.Display();
            Console.WriteLine($"Name: {Name} and City: {City}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
        }
    }

    public class Faculty : Person
    {
        public int noOfBooks { get; set; }

        public Faculty(string name, string city, int numOfBooks)
            : base(name, city)
        {
            noOfBooks = numOfBooks;
        }

        public void IsOutStanding()
        {
            if (noOfBooks > 5)
            {
                Console.WriteLine("Outstanding");
            }
            else
            {
                Console.WriteLine("Not Outstanding");
            }
        }
        public void Display()
        {
            //base.Display();
            Console.WriteLine($"Name: {Name} and City: {City}");
            Console.WriteLine($"Total number of books: {noOfBooks}");
        }
    }
}
