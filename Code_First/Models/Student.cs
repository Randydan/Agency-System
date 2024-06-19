using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
        public string Nationality { get; set; }
        public string Department { get; set; }
        public string Matricle { get; set; }
    }
}
