using Code_First.Models;
using SchoolSystem.Interfaces;
using System.Xml.Linq;

namespace SchoolSystem.Repository
{
    public class AdministratorsRepository : IAdministratorInterface
    {
        private readonly CodeFirstContext _context;
        public AdministratorsRepository(CodeFirstContext context)
        {
            _context = context;
        }
        public bool AdministratorsExists(int id)
        {
            return _context.Administrators.Any(p=>p.Id == id);
        }

        public bool CreateAdministrator(Administrators administrator)
        {
            _context.Add(administrator);
            return Save();
        }

        public ICollection<Administrators> GetAdministrators()
        {
            return _context.Administrators.OrderBy(p=>p.Id).ToList();
        }

        public Administrators GetAdministrators(string name)
        {
            return _context.Administrators.Where(p=>p.Name == name).FirstOrDefault();
        }

        public Administrators GetAdministrators(int id)
        {
            return _context.Administrators.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Save()
        {
            var  saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
