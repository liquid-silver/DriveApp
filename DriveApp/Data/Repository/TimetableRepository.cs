using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class TimetableRepository : ITimetable
    {
        private readonly AppDBContent content;
        public TimetableRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Timetable> AllTimetable => content.Timetable;

        public Timetable GetTimetableById(int id) => content.Timetable.FirstOrDefault(p => p.id == id);
    }
}
