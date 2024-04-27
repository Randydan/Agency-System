using Classes.Models;

namespace School_System.Interfaces
{
    public interface IDepartmentInterface
    {
        ICollection<Department> GetDepartments();

        Department GetDepartment(int id);

        Department GetDepartment(string description);

        bool DepartmentExists(int id);

        bool DepartmentExists(string description);

        bool createDepartment(Department department);
        bool Save();
    }
}
