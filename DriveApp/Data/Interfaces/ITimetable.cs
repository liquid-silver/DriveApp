using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface ITimetable
    {
        IEnumerable<Timetable> AllTimetable { get; }
        Timetable GetTimetableById(int id);
    }
}
