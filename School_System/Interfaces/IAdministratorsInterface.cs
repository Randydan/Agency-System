﻿using Classes;
using Classes.Models;

namespace School_System.Interfaces
{
    public interface IAdministratorsInterface
    {
        ICollection<Administrator> GetAdministrators();

        Administrator GetAdministrator(int AID);
        Administrator GetAdministrator(string Name);
        Administrator GetAdministrator(DateTime DOB);

        bool AdministratorExists(int  ID);

        bool AdministratorExists(string Name);

        bool createAdministrators(Administrator administrator);
        bool Save();
    }
}