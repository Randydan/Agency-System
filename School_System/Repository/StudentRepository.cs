using Classes.Models;
using School_System.Interfaces;
using System.Xml.Linq;

namespace School_System.Repository
{
    public class StudentRepository : IStudentInterface
    {
        private readonly School_ManagementContext _context;
        public StudentRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public Student GetMatricule(string matricule)
        {
            return _context.Students.Where(p => p.Matricule == matricule).FirstOrDefault();
        }

        public Student GetStudent(string name)
        {
            return _context.Students.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Student> GetStudents()
        {
            return _context.Students.OrderBy(p => p.Matricule).ToList();
        }

        public bool StudentExist(string matricule)
        {
            return _context.Students.Any(p => p.Matricule == matricule);
        }

        public bool StudentExists(string name)
        {
            return _context.Students.Any(p => p.Name == name);
        }
    }
}
