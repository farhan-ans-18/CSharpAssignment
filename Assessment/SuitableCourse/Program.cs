namespace SuitableCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Courses: ");
            int numOfCourses = int.Parse(Console.ReadLine());
            List<Course> courses = new List<Course>();
            for (int i = 0; i < numOfCourses; i++)
            {
                Console.WriteLine($"Course {i+1} Details");
                Console.WriteLine($"Enter the Id: ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Category: ");
                string category = Console.ReadLine();
                Console.WriteLine("Enter the Price: ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Course course = new Course()
                {
                    Id = id,
                    Name = name,
                    Category = category,
                    Price = price
                };

                courses.Add(course);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Enter the Price Limit:");
            Console.WriteLine("Enter the Min Limit");
            int minLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Max Limit");
            int maxLimit = int.Parse(Console.ReadLine());
            Console.WriteLine() ;

            var result = (from c in courses
                         where c.Price >= minLimit && c.Price <= maxLimit
                         select c).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No course Available in this limit: ");
            }
            else
            {
                int count = 1;
                Console.WriteLine($"Courses which limit {minLimit} to {maxLimit}\n");
                foreach (var r in result)
                {
                    Console.WriteLine($"Course {count} details\nCourse Id: {r.Id}\nCourse Name : {r.Name}\nCourse Category: {r.Category}\nCoursePrice: {r.Price}\n");
                    count++;
                }
            }
        }
    }

    class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

    }
}
