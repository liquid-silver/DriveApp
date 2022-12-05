using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockEmployment : IEmployment
    {
        private readonly ITimetable timetable = new MockTimetable();
        public IEnumerable<Employment> AllEmployment
        {
            get
            {
                return new List<Employment> {
                    new Employment {
                        timetableIdNavigation = timetable.AllTimetable.First(),
                        startTime = new TimeSpan(12, 0, 0),
                        finishTime = new TimeSpan(14, 0, 0),
                        description = "В ленту на Хасанской"}
                };
            }
        }

        public Employment GetEmploymentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
