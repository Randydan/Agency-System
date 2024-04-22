using Classes.Models;

namespace School_System.Interfaces
{
    public interface ICourseInterface
    {
        ICollection<Course> GetCourses();

        Course GetCourse(string Code);
        Course GetName(string Name);

        bool CourseExists(string Code);
        bool CourseExist(string Name);

    }
}
