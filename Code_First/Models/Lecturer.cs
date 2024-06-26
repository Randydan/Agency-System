﻿using System;
using System.Collections.Generic;

namespace Code_First.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DoB { get; set; } 
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Status { get; set; } = null!;
        public string Course { get; set; } = null!;

    }
}
