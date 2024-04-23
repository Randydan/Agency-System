using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Status { get; set; } = null!;
        public string Course { get; set; } = null!;
        public int Salary { get; set; }
        public int DepartmentDescription { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
