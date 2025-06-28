using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    // POCO class
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }
    //    public int? Age { get; set; }

    //}

    ////data annotations
    public class Employee
    {
        [Key]
        public virtual int EmpId { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Range(1000, 100000)]
        public virtual decimal Salary { get; set; }
        [Range(22, 50)]
        public virtual int? Age { get; set; }

        [ForeignKey("Dept")]
        [InverseProperty("Employees")]
        public virtual int? DepartmentId { get; set; }

        public virtual Department Dept { get; set; }

    }
}
