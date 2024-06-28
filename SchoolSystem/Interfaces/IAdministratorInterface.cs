using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IAdministratorInterface
    {
        ICollection<Administrators> GetAdministrators();
        Administrators GetAdministrator(string name);
        Administrators GetAdministrators(int id);
        bool AdministratorsExists(int id);
        bool AdministratorExist(string name);
        bool UpdateAdministrator(Administrators administrator);
        bool CreateAdministrator(Administrators administrators);
        bool DeleteAdministrator(Administrators administrator);
        bool Save();
    }
}
