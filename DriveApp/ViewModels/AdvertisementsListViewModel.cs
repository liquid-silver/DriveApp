using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.ViewModels
{
    public class AdvertisementsListViewModel
    {
        public IEnumerable<Advertisements> GetAdvertisements { get; set; }
        public string currVehicle { get; set; }
    }
}
