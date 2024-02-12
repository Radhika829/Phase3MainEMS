using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
namespace P3EmployeeMain.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        [StringLength(100)]
        public string Ename { get; set; }
        public int DId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
       // public virtualDeptMaster DeptMaster { get; set; }



    }
}
