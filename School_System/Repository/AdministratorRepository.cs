using Classes.Models;
using Microsoft.EntityFrameworkCore;
using School_System.Interfaces;

namespace School_System.Repository
{
    public class AdministratorRepository : IAdministratorsInterface
    {
        private readonly School_ManagementContext _context;
        public AdministratorRepository(School_ManagementContext context)
        {
                _context = context;

        }

        public Administrator GetAdministrator(int ID)
        {
            return _context.Administrators.Where(p => p.Id == ID).FirstOrDefault();
        }

        public Administrator GetAdministrator(string Name)
        {
            return _context.Administrators.Where(p => p.Name == Name).FirstOrDefault();
        }
        public Administrator GetAdministrator(DateTime DOB)
        {
            return _context.Administrators.Where(p=> p.Dob == DOB).FirstOrDefault();
        }

        public ICollection<Administrator> GetAdministrators()
        {
            return _context.Administrators.OrderBy(p => p.Id).ToList();
        }

        public bool AdministratorExists(int ID)
        {
            return _context.Administrators.Any(p => p.Id == ID);        
        }

        public bool AdministratorExists(string Name)
        {
            return _context.Administrators.Any(p => p.Name == Name);
        }

        public bool createAdministrators(Administrator administrator)
        {
            _context.Add(administrator);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
