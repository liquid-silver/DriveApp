using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public byte[] password { get; set; }
        public int roleId { get; set; }

        public virtual Roles roleIdNavigation { get; set; }
        public virtual Drivers drivers { get; set; }
    }
}
