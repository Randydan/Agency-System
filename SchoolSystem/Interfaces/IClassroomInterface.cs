using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IClassroomInterface
    {
        ICollection<Classroom> GetClassrooms();

        Classroom GetClassroom(int id);
        Classroom GetClassroom(string name);
        bool ClassroomExists(int id);

        bool CreateClassrooms(Classroom classroom);
        bool Save();
    }
}
