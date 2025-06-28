using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public virtual int StudentId { get; set; }
        [ForeignKey("Course")]
        public virtual int CourseId  { get; set; }
        public virtual int Grade { get; set; }

        public virtual Student student { get; set; }
        public virtual Course course { get; set; }
    }
}
