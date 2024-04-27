using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CourseDTO
    {
        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
