using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IOfficeInterface
    {
        ICollection<Office> GetOffice();
        Office GetOffice(string description);
        Office GetOffice(int id);
        bool OfficeExists(int id);
        bool UpdateOffice(Office office);
        bool DeleteOffice(Office office);
        bool CreateOffice(Office office);
        bool Save();
    }
}
