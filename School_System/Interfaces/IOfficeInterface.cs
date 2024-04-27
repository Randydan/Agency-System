using Classes.Models;

namespace School_System.Interfaces
{
    public interface IOfficeInterface
    {
        ICollection<Office> GetOffices();

        Office GetOffice(int id);
        Office GetOffice(string description);

        bool OfficeExists(int id);
        bool OfficeExists(string description);

        bool createOffice(Office office);
        bool Save();
    }
}
