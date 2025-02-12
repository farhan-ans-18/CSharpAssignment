namespace ArrayObject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees[] employees = new Employees[2];
            employees[0] = new Employees(1, "Ravi", 111, 201);
            employees[1] = new Employees(2, "Raghu", 112, 202);
            int totalSal = 0;
            for (int i = 0; i < employees.Length; i++)
            {
           
                Console.WriteLine(employees[i].ToString());
                totalSal += employees[i].salary;
             
            }

            Console.WriteLine($"totalSal : {totalSal}");
        }

        class Employees
        {
            int empCode;
            string empName;
            public int salary { get; set;}
            int deptId;

            public Employees(int empCode, string empName, int salary, int deptId)
            {
                this.empCode = empCode;
                this.empName = empName;
                this.salary = salary;
                this.deptId = deptId;
            }

            public override string ToString()
            {
                return $"Employee ID : {empCode}\nEmployee Name: {empName}\nSalary: {salary}\nDeptId: {deptId}\n*******************\n";
            }
        }
    }
}
