using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Advertisements
    {
        public int id { get; set; }
        public int vehicleId { get; set; }
        public double priceInside { get; set; }
        public double priceOutside { get; set; }
        public string description { get; set; }

        public virtual Vehicles vehicleIdNavigation { get; set; }
    }
}
