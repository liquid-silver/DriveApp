using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Trucks
    {
        [Key]
        public int id { get; set; }
        public double loadCapacity { get; set; }
        public double capacity { get; set; }

        [ForeignKey("id")]
        public virtual Vehicles idNavigation { get; set; }
    }
}
