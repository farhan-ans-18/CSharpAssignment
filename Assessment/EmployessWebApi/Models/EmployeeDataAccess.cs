
namespace EmployessWebApi.Models
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly EmployeeDbContext employeeDb;
        public EmployeeDataAccess(EmployeeDbContext employeeDb)
        {
            this.employeeDb = employeeDb;
        }
        public void Add(Employee employee)
        {
            employeeDb.Employees.Add(employee);
            employeeDb.SaveChanges();
        }

        public void Delete(int id)
        {
            var record = employeeDb.Employees.Find(id);
            if (record != null)
            {
                employeeDb.Employees.Remove(record);
                employeeDb.SaveChanges();
            }
            else
            {
                throw new Exception("Id not found");
            }
        }

        public List<Employee> GetAllEmployee()
        {
          return employeeDb.Employees.ToList();
        }

        public Employee GetbyId(int id)
        {
            var record = employeeDb.Employees.Find(id);
            if (record != null)
            {
                return record;
               
            }
            else
            {
                throw new Exception("Id not found");
            }
        }

        public void Update(Employee employee)
        {
           var record = employeeDb.Employees.Find(employee.Ecode);
            if (record != null)
            {
                record.EName = employee.EName;
                record.Salary = employee.Salary;
                record.DepId = employee.DepId;
                employeeDb.SaveChanges();
            }
            else
            {
                throw new Exception("Record not found");
            }
        }
    }
}
