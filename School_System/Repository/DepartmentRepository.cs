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

        public bool createDepartment(Department department)
        {
            _context.Add(department);

            return Save();
        }

        public bool DepartmentExists(int id)
        {
            return _context.Departments.Any(p => p.DId == id);
        }

        public bool DepartmentExists(string description)
        {
            return _context.Departments.Any(p => p.Description == description);
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Where(p => p.DId == id).FirstOrDefault();
        }

        public Department GetDepartment(string description)
        {
            return _context.Departments.Where(p => p.Description == description).FirstOrDefault();
        }

        public ICollection<Department> GetDepartments()
        {
            return _context.Departments.OrderBy(p => p.DId).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0? true: false;
        }
    }
}
