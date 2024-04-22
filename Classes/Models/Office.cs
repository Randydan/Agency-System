using System;
using System.Collections.Generic;

namespace Classes.Models
{
    public partial class Office
    {

        public int Id { get; set; }
        public string Department { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
