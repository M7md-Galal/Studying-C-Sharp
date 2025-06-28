using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    [Keyless]
    public class EmployeeDepartmentView
    {
        public int  EmpId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
