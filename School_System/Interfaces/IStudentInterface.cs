using Classes.Models;

namespace School_System.Interfaces
{
    public interface IStudentInterface
    {
        ICollection<Student> GetStudents();

        Student GetMatricule(string matricule);
        Student GetStudent(string name);
        bool StudentExist(string matricule);
        bool StudentExists(string name);
    }
}
