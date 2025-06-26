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
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1000, 100000)]
        public decimal Salary { get; set; }
        [Range(22, 50)]
        public int? Age { get; set; }

        [ForeignKey("Dept")]
        public int? DepartmentDeptId { get; set; }

        public Department Dept { get; set; }

    }
}
