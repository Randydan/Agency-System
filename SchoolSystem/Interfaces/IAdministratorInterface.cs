using Code_First.Models;

namespace SchoolSystem.Interfaces
{
    public interface IAdministratorInterface
    {
        ICollection<Administrators> GetAdministrators();
        Administrators GetAdministrators(string name);
        Administrators GetAdministrators(int id);
        bool AdministratorsExists(int id);

        bool CreateAdministrator(Administrators administrators);
        bool Save();
    }
}
