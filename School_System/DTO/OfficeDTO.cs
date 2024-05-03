using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class OfficeDTO
    {
        
        public int Id { get; set; }
        public string Department { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
