using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P3EmployeeMain.Models
{
    [Table("DeptMaster")]
    public class Department
    {
        [Key]
        public int DId { get; set; }
        [StringLength(100)]
        public string DName { get; set; }
        public string PropertyName { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }


    }
}
