using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockTimetable : ITimetable
    {
        private readonly IDrivers drivers = new MockDrivers();
        public IEnumerable<Timetable> AllTimetable
        {
            get
            {
                return new List<Timetable> {
                    new Timetable {
                        driverIdNavigation = drivers.AllDrivers.First(),
                        date = new DateTime(2022, 12, 15),
                        startTime =  new TimeSpan(8, 0, 0),
                        finishTime =  new TimeSpan(17, 0, 0) }
                };
            }
        }

        public Timetable GetTimetableById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
