using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Models
{
    public class Employment
    {
        public int id { get; set; }
        public int timetableId { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan finishTime { get; set; }
        public string description { get; set; }

        public virtual Timetable timetableIdNavigation { get; set; }
    }
}
