using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class UsersRepository : IUsers
    {
        private readonly AppDBContent content;
        public UsersRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Users> AllUsers => content.Users;

        public Users GetUserById(int id) => content.Users.FirstOrDefault(p => p.id == id);
    }
}
