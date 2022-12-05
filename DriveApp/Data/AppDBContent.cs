using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Advertisements> Advertisements { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Employment> Employment { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Timetable> Timetable { get; set; }
        public DbSet<Trucks> Trucks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
    }
}
