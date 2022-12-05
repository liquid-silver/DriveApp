using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class TrucksRepository : ITrucks
    {
        private readonly AppDBContent content;
        public TrucksRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Trucks> AllTrucks => content.Trucks;

        public Trucks GetTruckById(int id) => content.Trucks.FirstOrDefault(p => p.id == id);
    }
}
