namespace EmployessWebApi.Models
{
    public interface IEmployeeDataAccess
    {
        void Add(Employee employee);
        void Delete(int id);
        void Update (Employee employee);
        Employee GetbyId(int id);
        List<Employee> GetAllEmployee();
    }
}
