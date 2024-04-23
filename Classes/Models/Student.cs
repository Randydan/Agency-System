using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Student
    {
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Status { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public int DepartmentDescription { get; set; }
        public string Matricule { get; set; } = null!;

        public virtual Department Department { get; set; } = null!;
    }
}
