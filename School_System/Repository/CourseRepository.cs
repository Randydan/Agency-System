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

        public bool CourseExist(string Name)
        {
            return _context.Courses.Any(p => p.Name == Name);
        }

        public bool CourseExists(string Code)
        {
            return _context.Courses.Any(p => p.Code == Code);
        }

        public Course GetCourse(string Code)
        {
            return _context.Courses.Where(p => p.Code == Code).FirstOrDefault();
        }

        public ICollection<Course> GetCourses()
        {
            return _context.Courses.OrderBy(p => p.Code).ToList();
        }

        Course ICourseInterface.GetName(string Name)
        {
            return _context.Courses.Where(p => p.Name == Name).FirstOrDefault();
        }
    }
}
