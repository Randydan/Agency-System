using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface ICourseInterface
    {
        ICollection<Course> GetCourses();
        Course GetCourse(string code);
        Course FetchCourse(string name);
        bool CourseExists(string code);
        bool CreateCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(Course course);
        bool Save();
    }
}
