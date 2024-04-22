using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Course
    {
        public Course()
        {
            Classrooms = new HashSet<Classroom>();
            Students = new HashSet<Student>();
        }

        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
