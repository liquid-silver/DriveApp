using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface IUsers
    {
        IEnumerable<Users> AllUsers { get; }
        Users GetUserByLogin(string login);
    }
}
