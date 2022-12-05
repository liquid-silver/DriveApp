using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Drivers
    {
        [Key]
        public int id { set; get; }
        public string fio { set; get; }
        public string telephone { set; get; }
        public int driverLicense { set; get; }
        public DateTime registrationDate { set; get; }
        public int photoId { set; get; }

        [ForeignKey ("id")]
        public virtual Users idNavigation { get; set; }
        public virtual Images photoIdNavigation { get; set; }
        public virtual List<Timetable> timetable { get; set; }
        public virtual List<Vehicles> vehicles { get; set; }
    }
}
