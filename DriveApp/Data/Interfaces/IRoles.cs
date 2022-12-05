using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface IRoles
    {
        IEnumerable<Roles> AllRoles { get; }
        Roles GetRoleById(int id);
    }
}
