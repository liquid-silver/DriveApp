using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockTrucks : ITrucks
    {
        private readonly IVehicles vehicles = new MockVehicles();
        public IEnumerable<Trucks> AllTrucks
        {
            get
            {
                return new List<Trucks> {
                    new Trucks {
                        idNavigation = vehicles.AllVehicles.Last(),
                        loadCapacity = 20,
                        capacity = 82 }
                };
            }
        }

        public Trucks GetTruckById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
