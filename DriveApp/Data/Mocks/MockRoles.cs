using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockRoles : IRoles
    {
        public IEnumerable<Roles> AllRoles
        {
            get
            {
                return new List<Roles> {
                    new Roles { name = "admin"},
                    new Roles { name = "director"},
                    new Roles { name = "driver"}
                };
            }
        }

        public Roles GetRoleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
