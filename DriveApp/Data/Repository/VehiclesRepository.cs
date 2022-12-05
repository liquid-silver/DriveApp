using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class VehiclesRepository : IVehicles
    {
        private readonly AppDBContent content;
        public VehiclesRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Vehicles> AllVehicles => content.Vehicles;
        public IEnumerable<Vehicles> CategoryVehicles => content.Vehicles.Include(c => c.categoryId);

        public Vehicles GetVehicleById(int id) => content.Vehicles.FirstOrDefault(p => p.id == id);
    }
}
