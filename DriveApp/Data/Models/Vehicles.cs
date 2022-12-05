using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Vehicles
    {
        public int id { get; set; }
        public string name { get; set; }
        public int driverId { get; set; }
        public int categoryId { get; set; }
        public int yearOfIssue { get; set; }
        public int seats { get; set; }
        public int photoId { get; set; }

        public virtual Drivers driverIdNavigation { get; set; }
        public virtual Categories categoryIdNavigation { get; set; }
        public virtual Images photoIdNavigation { get; set; }
        public virtual Trucks trucks { get; set; }
        public virtual List<Advertisements> Advertisements { get; set; }
    }
}
