using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class RolesRepository : IRoles
    {
        private readonly AppDBContent content;
        public RolesRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Roles> AllRoles => content.Roles;

        public Roles GetRoleById(int id) => content.Roles.FirstOrDefault(p => p.id == id);
    }
}
