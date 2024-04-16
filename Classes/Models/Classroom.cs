using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Classroom
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string CourseCode { get; set; } = null!;
        public int DepartmentId { get; set; }

        public virtual Course CourseCodeNavigation { get; set; } = null!;
    }
}
