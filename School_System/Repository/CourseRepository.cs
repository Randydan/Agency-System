using Classes.Models;
using School_System.Interfaces;
using System.Linq;
using System.Xml.Linq;

namespace School_System.Repository
{
    public class CourseRepository : ICourseInterface
    {
        private readonly School_ManagementContext _context;
        public CourseRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public bool CourseExist(string Description)
        {
            return _context.Courses.Any(p => p.Description == Description);
        }

        public bool CourseExists(string CCode)
        {
            return _context.Courses.Any(p => p.CCode == CCode);
        }

        public bool CreateCourse(Course course)
        {
            _context.Add(course);

            return Save();
        }

        public Course GetCourse(string CCode)
        {
            return _context.Courses.Where(p => p.CCode == CCode).FirstOrDefault();
        }

        public ICollection<Course> GetCourses()
        {
            return _context.Courses.OrderBy(p => p.CCode).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        Course ICourseInterface.GetName(string Description)
        {
            return _context.Courses.Where(p => p.Description == Description).FirstOrDefault();
        }
    }
}
