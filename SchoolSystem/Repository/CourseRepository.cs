using Code_First.Models;
using SchoolSystem.Interfaces;
using System.Xml.Linq;

namespace SchoolSystem.Repository
{
    public class CourseRepository : ICourseInterface
    {
        private readonly CodeFirstContext _context;

        public CourseRepository(CodeFirstContext context)
        {
            _context = context;
        }

        public bool CourseExists(int ID)
        {
            return _context.Courses.Any(p=>p.ID == ID);
        }

        public bool CreateCourse(Course course)
        {
            _context.Add(course);
            return Save();
        }

        public bool DeleteCourse(Course course)
        {
            _context.Remove(course);
            return Save();
        }

        public Course FetchCourse(string name)
        {
            return _context.Courses.Where(p=>p.Name == name).FirstOrDefault();
        }

        public Course GetCourse(string code)
        {
            return _context.Courses.Where(p => p.Code == code).FirstOrDefault();
        }

        public ICollection<Course> GetCourses()
        {
            return _context.Courses.OrderBy(p=>p.Code).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false; 
        }

        public bool UpdateCourse(Course course)
        {
            _context.Update(course);

            return Save();
        }
    }
}
