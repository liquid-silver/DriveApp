using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Roles
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Users> users { get; set; }
    }
}
