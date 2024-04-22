using Classes.Models;
using School_System.Interfaces;

namespace School_System.Repository
{
    public class ClassroomRepository : IClassroomInterface
    {
        private readonly School_ManagementContext _context;
        public ClassroomRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public bool ClassroomExists(int ID)
        {
            return _context.Classrooms.Any(p => p.Id == ID);
        }

        public bool ClassroomExists(string description)
        {
            return _context.Classrooms.Any(p => p.Description == description);
        }

        public Classroom GetClassroom(int ID)
        {
            return _context.Classrooms.Where(p=> p.Id == ID).FirstOrDefault();
        }

        public Classroom GetClassroom(string description)
        {
            return _context.Classrooms.Where(p => p.Description == description).FirstOrDefault();
        }

        public ICollection<Classroom> GetClassrooms()
        {
            return _context.Classrooms.OrderBy(p => p.Id).ToList();
        }
    }
}
