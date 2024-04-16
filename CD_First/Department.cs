using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_First
{
    internal class Department
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public string Courses { get; set; }
        public string[] Students { get; set; }
        public string[] Lecturers { get; set; }
    }
}
