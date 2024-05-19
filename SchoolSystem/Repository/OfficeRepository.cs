using Code_First.Models;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Repository
{
    public class OfficeRepository : IOfficeInterface
    {
        private readonly CodeFirstContext _context;

        public OfficeRepository(CodeFirstContext context)
        {
            _context = context;   
        }

        public bool CreateOffice(Office office)
        {
            _context.Add(office);
            return Save();
        }

        public bool DeleteOffice(Office office)
        {
            _context.Remove(office);
            return Save();
        }

        public ICollection<Office> GetOffice()
        {
            return _context.Offices.OrderBy(p=>p.ID).ToList();
        }

        public Office GetOffice(string description)
        {
            return _context.Offices.Where(p=>p.Description == description).FirstOrDefault();
        }

        public Office GetOffice(int id)
        {
            return _context.Offices.Where(p=>p.ID == id).FirstOrDefault();
        }

        public bool OfficeExists(int id)
        {
            return _context.Offices.Any(p=> p.ID == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateOffice(Office office)
        {
            _context.Update(office);
            return Save();
        }
    }
}
