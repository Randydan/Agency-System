using Code_First.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SchoolSystem.Interfaces;
using System.Xml.Linq;

namespace SchoolSystem.Repository
{
    public class DepartmentRepository : IDepartmentInterface
    {
       private readonly CodeFirstContext _context;

        public DepartmentRepository(CodeFirstContext context)
        {
            _context = context;
        }

        public bool CreateDepartment(Department department)
        {
            _context.Add(department);
            return Save();
        }

        public bool DeleteDepartment(Department department)
        {
            _context.Remove(department);
            return Save();
        }

        public bool DepartmentExists(int id)
        {
            return _context.Departments.Any(p=> p.ID ==id);
        }

        public Department GetDepartment(string name)
        {
            return _context.Departments.Where(p=>p.Name == name).FirstOrDefault();
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Where(p => p.ID == id).FirstOrDefault();
        }

        public ICollection<Department> GetDepartments()
        {
            return _context.Departments.OrderBy(p=>p.ID).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false; 
        }

        public bool UpdateDepartment(Department department)
        {
            _context.Update(department);
            return Save();
        }
    }
}
