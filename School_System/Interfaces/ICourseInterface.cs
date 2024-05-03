using Classes.Models;

namespace School_System.Interfaces
{
    public interface ICourseInterface
    {
        ICollection<Course> GetCourses();

        Course GetCourse(string CCode);
        Course GetName(string description);

        bool CourseExists(string CCode);
        bool CourseExist(string description);

        bool CreateCourse(Course course);
        bool Save();

    }
}
