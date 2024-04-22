using Classes.Models;
using School_System.Interfaces;

namespace School_System.Repository
{
    public class DepartmentRepository : IDepartmentInterface
    {
        private readonly School_ManagementContext _context;
        public DepartmentRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public bool DepartmentExists(int id)
        {
            return _context.Departments.Any(p => p.Id == id);
        }

        public bool DepartmentExists(string description)
        {
            return _context.Departments.Any(p => p.Description == description);
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Where(p => p.Id == id).FirstOrDefault();
        }

        public Department GetDepartment(string description)
        {
            return _context.Departments.Where(p => p.Description == description).FirstOrDefault();
        }

        public ICollection<Department> GetDepartments()
        {
            return _context.Departments.OrderBy(p => p.Id).ToList();
        }
    }
}
