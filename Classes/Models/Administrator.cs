using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Administrator
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; } = null!;
        public string Post { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Status { get; set; } = null!;
    }
}
