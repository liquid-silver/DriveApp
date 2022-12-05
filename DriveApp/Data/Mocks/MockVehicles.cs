using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockVehicles : IVehicles
    {
        private readonly IDrivers drivers = new MockDrivers();
        private readonly ICategories categories = new MockCategories();
        private readonly IImages images = new MockImages();
        public IEnumerable<Vehicles> AllVehicles
        {
            get
            {
                return new List<Vehicles> {
                    new Vehicles { 
                        name = "Volvo XC60", 
                        driverIdNavigation = drivers.AllDrivers.First(), 
                        categoryIdNavigation = categories.AllCategories.First(), 
                        yearOfIssue = 2019, 
                        seats = 4, 
                        photoIdNavigation = images.AllImages.First() },
                    new Vehicles {
                        name = "Volvo FH16",
                        driverIdNavigation = drivers.AllDrivers.First(),
                        categoryIdNavigation = categories.AllCategories.Last(),
                        yearOfIssue = 2016,
                        seats = 1,
                        photoIdNavigation = images.AllImages.Last() }
                };
            }
        }
        public IEnumerable<Vehicles> CategoryVehicles { get; set; }

        public Vehicles GetVehicleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
