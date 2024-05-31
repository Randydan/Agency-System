using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface ICourseInterface
    {
        ICollection<Course> GetCourses();
        Course GetCourse(int ID);
        Course FetchCourse(string name);
        bool CourseExists(int ID);
        bool CreateCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(Course course);
        bool Save();
    }
}
