using Classes.Models;

namespace School_System.Interfaces
{
    public interface IClassroomInterface
    {
        ICollection<Classroom> GetClassrooms();

        Classroom GetClassroom(int id);
        Classroom GetClassroom(string Description);

        bool ClassroomExists(int id);

        bool ClassroomExists(string Description);
    }
}
