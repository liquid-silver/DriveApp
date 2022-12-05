using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockDrivers : IDrivers
    {
        private readonly IUsers users = new MockUsers();
        private readonly IImages images = new MockImages();
        public IEnumerable<Drivers> AllDrivers
        {
            get
            {
                return new List<Drivers> {
                    new Drivers {
                        idNavigation = users.AllUsers.First(),
                        fio = "Иванов Иван Иванович",
                        telephone = "89117777777",
                        driverLicense = 2000,
                        registrationDate = DateTime.Now.Date,
                        photoIdNavigation = images.AllImages.First() }
                };
            }
        }

        public Drivers GetDriverById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
