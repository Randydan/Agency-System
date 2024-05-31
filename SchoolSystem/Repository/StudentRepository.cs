using Code_First.Models;
using SchoolSystem.Interfaces;
using System.Xml.Linq;

namespace SchoolSystem.Repository
{
    public class StudentRepository : IStudentInterface
    {
        private readonly CodeFirstContext _context;

        public StudentRepository(CodeFirstContext context)
        {
            _context = context;
        }

        public Student GetStudents(string name)
        {
            return _context.Students.Where(p => p.Name == name).FirstOrDefault();
        }

        public bool StudentsExists(int ID)
        {
            return _context.Students.Any(p=>p.ID == ID);
        }

        public ICollection<Student> GetStudents()
        {
            return _context.Students.OrderBy(p => p.ID).ToList();
        }

        public Student GetStudent(int ID)
        {
            return _context.Students.Where(p => p.ID == ID).FirstOrDefault();
        }

        public bool CreateStudent(Student student)
        {
            _context.Add(student);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            
            return saved > 0? true: false;
        }

        public bool UpdateStudent(Student student)
        {
            _context.Update(student);
            return Save();

        }

        public bool DeleteStudent(Student student)
        {
            _context.Remove(student);
            return Save();
        }
    }
}
