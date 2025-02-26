using System.Reflection.Metadata.Ecma335;
using EmployessWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployessWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeDataAccess dal;
        public EmployeesController(IEmployeeDataAccess dal)
        {
            this.dal = dal;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Employee> GetAll()
        {
            return dal.GetAllEmployee();
        }

        // GET api/<EmployeesController>/5
        [HttpGet()]
        [Route("GetbyEcode/{id}")]
        public Employee GetbyEcode(int id)
        {
            return dal.GetbyId(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]

        [Route("AddEmp")]
        public void AddEmp([FromBody] Employee emp)
        {
            dal.Add(emp);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut()]
        [Route("UpdateById/{id}")]
        public void UpdateById(int id, [FromBody] Employee emp)
        {
            dal.Update(emp);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteById(int id)
        {
            dal.Delete(id);
        }
    }
}
