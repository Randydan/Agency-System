using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IDepartmentInterface
    {
        ICollection<Department> GetDepartments();
        Department GetDepartment(string name);
        Department GetDepartment(int id);
        bool DepartmentExists(int id);

        bool CreateDepartment(Department department);
        bool Save();
    }
}
