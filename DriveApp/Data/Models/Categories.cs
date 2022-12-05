using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Categories
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Vehicles> vehicles { get; set; }
    }
}
