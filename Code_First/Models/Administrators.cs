using System.ComponentModel.DataAnnotations;

namespace Code_First.Models
{
    public class Administrators
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public string? Post { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
    }
}