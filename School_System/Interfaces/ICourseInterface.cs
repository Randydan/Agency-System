using Classes.Models;

namespace School_System.Interfaces
{
    public interface ICourseInterface
    {
        ICollection<Course> GetCourses();

        Course GetCourse(string Code);
        Course GetName(string description);

        bool CourseExists(string Code);
        bool CourseExist(string description);

        bool CreateCourse(Course course);
        bool Save();

    }
}
