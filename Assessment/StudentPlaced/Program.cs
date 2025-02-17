namespace StudentPlaced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlacedStudent> studentList = new List<PlacedStudent>();
            Console.WriteLine("Enter the number of Comapnies: ");
            int numOfCompanies = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCompanies; i++)
            {
                Console.WriteLine("Enter the Company Name: ");
                string cName = Console.ReadLine();
                Console.WriteLine("Enter the Student Name: ");
                string sName = Console.ReadLine();
                PlacedStudent student = new PlacedStudent()
                {
                    CompanyName = cName,
                    StudentName = sName
                };
                studentList.Add(student);

            }

            var result = studentList
                .GroupBy(c => c.CompanyName)
                .Select(g => new
                {
                    cName = g.Key,
                    sName = g.OrderBy(s => s.StudentName)
                });



            foreach (var r in result)
            {

                Console.WriteLine($"Company Name: {r.cName}");
                foreach (var student in r.sName)
                {
                    Console.WriteLine(student.StudentName);
                }
            }

        }
    }
    class PlacedStudent
    {
        public string CompanyName { get; set; }
        public string StudentName { get; set; }

    }
}
