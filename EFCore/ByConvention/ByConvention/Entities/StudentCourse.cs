using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    internal class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId  { get; set; }
        public int Grade { get; set; }

        public Student student { get; set; }
        public Course course { get; set; }
    }
}
