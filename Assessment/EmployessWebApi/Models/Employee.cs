using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EmployessWebApi.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("ecode")]
        public int Ecode { get; set; }
        [Column("ename")]
        public string EName { get; set; }
        [Column("salary")]
        public int Salary { get; set; }
        [Column("depid")]
        public int  DepId {  get; set; }
    }
}
