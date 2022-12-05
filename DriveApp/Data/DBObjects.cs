using DriveApp.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //if (!content.Vehicles.Any())
            //    content.Vehicles.AddRange(Vehicles.Select(c => c.Value));

            //if (!content.Advertisements.Any())
            //    content.AddRange(
            //            new Advertisements
            //            {
            //                vehicleIdNavigation = vehicles.AllVehicles.First(),
            //                priceInside = 100,
            //                priceOutside = 300,
            //                description = "Отличная машина и водитель приветливый!"
            //            },
            //            new Advertisements
            //            {
            //                vehicleIdNavigation = vehicles.AllVehicles.Last(),
            //                priceInside = 1000,
            //                priceOutside = 3000,
            //                description = "Тягач!"
            //            }
            //        );

            //content.SaveChanges();
        }

        //public static Dictionary<string, Vehicles> vehicles;   
        //public static Dictionary<string, Vehicles> Vehicles
        //{
        //    get
        //    {
        //        if(vehicles==null)
        //        {
        //            var list = new Vehicles[]
        //            {
        //                new Vehicles {
        //                name = "Volvo XC60",
        //                driverIdNavigation = drivers.AllDrivers.First(),
        //                categoryIdNavigation = categories.AllCategories.First(),
        //                yearOfIssue = 2019,
        //                seats = 4,
        //                photoIdNavigation = images.AllImages.First() },
        //            new Vehicles {
        //                name = "Volvo FH16",
        //                driverIdNavigation = drivers.AllDrivers.First(),
        //                categoryIdNavigation = categories.AllCategories.Last(),
        //                yearOfIssue = 2016,
        //                seats = 1,
        //                photoIdNavigation = images.AllImages.Last() }
        //            };

        //            vehicles = new Dictionary<string, Vehicles>();
        //            foreach (Vehicles element in list)
        //                vehicles.Add(element.name, element);

        //        }

        //        return vehicles;
        //    }
        //}
    }
}
