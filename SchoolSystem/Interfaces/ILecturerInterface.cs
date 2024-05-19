using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface ILecturerInterface
    {
        ICollection<Lecturer> GetLecturers();
        Lecturer GetLecturer(string name);
        Lecturer GetLecturer(int id);
        bool LecturerExists(int id);
        bool UpdateLecturer(Lecturer lecturer);
        bool DeleteLecturer(Office office);
        bool CreateLecturer(Lecturer lecturer);
        bool Save();
    }
}
