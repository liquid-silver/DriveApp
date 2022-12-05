using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Images
    {
        public int id { get; set; }
        public string filename { get; set; }
        public byte[] data { get; set; }

        public virtual List<Drivers> drivers { get; set; }
        public virtual List<Vehicles> vehicles { get; set; }
    }
}
