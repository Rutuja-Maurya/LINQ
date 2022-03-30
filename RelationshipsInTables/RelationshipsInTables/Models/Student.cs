using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RelationshipsInTables.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public int GradeId { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual Grade Grade { get; set; }

    }
}
