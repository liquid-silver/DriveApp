using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Timetable
    {
        public int id { get; set; }
        public int driverId { get; set; }
        public DateTime date { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan finishTime { get; set; }

        public virtual Drivers driverIdNavigation { get; set; }
        public virtual List<Employment> employment { get; set; }
    }
}
