using Classes.Models;

namespace School_System.Interfaces
{
    public interface ILecturerInterface
    {
        ICollection<Lecturer> GetLecturers();

        Lecturer GetLecturer(int id);
        Lecturer GetLecturer(string Name);
        bool LecturerExists(int id);
        bool LecturerExists(string Name);

        bool createLecturer(Lecturer lecturer);
        bool Save();
    }
}
