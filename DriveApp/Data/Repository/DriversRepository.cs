using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class DriversRepository : IDrivers
    {
        private readonly AppDBContent content;
        public DriversRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Drivers> AllDrivers => content.Drivers;

        public Drivers GetDriverById(int id) => content.Drivers.FirstOrDefault(p => p.id == id);

        //public void primer(string[] args)
        //{
        //    var context = new SchoolContext();
        //    var studentsWithSameName = context.Students
        //                                      .Where(s => s.FirstName == GetName())
        //                                      .ToList();
        //}

        //public static string GetName()
        //{
        //    return "Bill";
        //}
    }
}
