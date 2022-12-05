using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockAdvertisements : IAdvertisements
    {
        private readonly IVehicles vehicles = new MockVehicles();
        public IEnumerable<Advertisements> AllAdvertisements 
        {
            get
            {
                return new List<Advertisements> {
                    new Advertisements { 
                        vehicleIdNavigation = vehicles.AllVehicles.First(), 
                        priceInside = 100, 
                        priceOutside = 300, 
                        description = "Отличная машина и водитель приветливый!"},
                     new Advertisements {
                        vehicleIdNavigation = vehicles.AllVehicles.Last(),
                        priceInside = 1000,
                        priceOutside = 3000,
                        description = "Тягач!"}
                };
            }
        }

        public Advertisements GetAdvertisementById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
