using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IStudentInterface
    {
        ICollection<Student> GetStudents();
        Student GetStudents(string name);
        Student GetStudent(string Matricule);
        bool StudentsExists(string Matricule);
        bool UpdateStudent(Student student);
        bool DeleteStudent(Student student);
        bool CreateStudent(Student student);
        bool Save();
    }
}
