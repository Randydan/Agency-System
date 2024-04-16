using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Department
    {
        public Department()
        {
            Lecturers = new HashSet<Lecturer>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public string CoursCode { get; set; } = null!;

        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
