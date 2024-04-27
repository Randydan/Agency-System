using Classes.Models;
using School_System.Interfaces;
using System.Linq;

namespace School_System.Repository
{
    public class OfficeRepository : IOfficeInterface
    {
        private readonly School_ManagementContext _context;
        public OfficeRepository(School_ManagementContext context)
        {
            _context = context;

        }

        public bool createOffice(Office office)
        {
            _context.Add(office);
            return Save();
        }

        public Office GetOffice(int id)
        {
            return _context.Offices.Where(p => p.Id == id).FirstOrDefault();
        }

        public Office GetOffice(string description)
        {
            return _context.Offices.Where(p => p.Description == description).FirstOrDefault();
        }

        public ICollection<Office> GetOffices()
        {
            return _context.Offices.OrderBy(p => p.Id).ToList();
        }

        public bool OfficeExists(int id)
        {
            return _context.Offices.Any(p => p.Id == id);
        }

        public bool OfficeExists(string description)
        {
            return _context.Offices.Any(p => p.Description == description);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0? true: false;
        }
    }
}
