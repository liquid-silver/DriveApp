using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockUsers : IUsers
    {
        private readonly IRoles roles = new MockRoles();
        public IEnumerable<Users> AllUsers
        {
            get
            {
                return new List<Users> {
                    new Users {
                        login = "driver",
                        password = "pass",
                        roleIdNavigation = roles.AllRoles.Last() }
                };
            }
        }

        public Users GetUserByLogin(string login)
        {
            throw new NotImplementedException();
        }

        //private static byte[] GetHash(string password)
        //{
        //    SHA256 shaM = new SHA256Managed();
        //    byte[] result = shaM.ComputeHash(new UTF8Encoding().GetBytes(password));
        //    return result;
        //}
    }
}
