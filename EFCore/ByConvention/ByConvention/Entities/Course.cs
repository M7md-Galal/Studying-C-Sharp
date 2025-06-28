using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    public class Course
    {
        public virtual int Id { get; set; }
        public virtual string Tittle { get; set; }

        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
    }
}
