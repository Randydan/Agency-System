using Classes.Models;
using School_System.Interfaces;

namespace School_System.Repository
{
    public class LecturerRepository : ILecturerInterface
    {
        private readonly School_ManagementContext _context;
        public LecturerRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public bool createLecturer(Lecturer lecturer)
        {
            _context.Add(lecturer);
            return Save();
        }

        public Lecturer GetLecturer(int id)
        {
            return _context.Lecturers.Where(p => p.Id == id).FirstOrDefault();
        }

        public Lecturer GetLecturer(string Name)
        {
            return _context.Lecturers.Where(p => p.Name == Name).FirstOrDefault();
        }

        public ICollection<Lecturer> GetLecturers()
        {
            return _context.Lecturers.OrderBy(p => p.Id).ToList();
        }

        public bool LecturerExists(int id)
        {
            return _context.Lecturers.Any(p => p.Id == id);
        }

        public bool LecturerExists(string Name)
        {
            return _context.Lecturers.Any(p => p.Name == Name);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
