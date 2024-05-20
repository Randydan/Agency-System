using Code_First.Models;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Repository
{
    public class ClassroomRepository : IClassroomInterface
    {
        private readonly CodeFirstContext _context;
        public ClassroomRepository(CodeFirstContext context)
        {
            _context = context;
        }

        public bool ClassroomExists(int id)
        {
            return _context.Classrooms.Any(p => p.ID == id);
        }

        public bool CreateClassrooms(Classroom classroom)
        {
            _context.Add(classroom);
            return Save();
        }

        public bool DeleteClassroom(Classroom classroom)
        {
            _context.Remove(classroom);
            return Save();
        }

        public Classroom GetClassroom(int id)
        {
            return _context.Classrooms.Where(p=> p.ID == id).FirstOrDefault();
        }

        public Classroom GetClassroom(string name)
        {
            return _context.Classrooms.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Classroom> GetClassrooms()
        {
            return _context.Classrooms.OrderBy(p=>p.ID).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateClassroom(Classroom classroom)
        {
            _context.Update(classroom);

            return Save();
        }
    }
}
