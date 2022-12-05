using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    public interface IAdvertisements
    {
        IEnumerable<Advertisements> AllAdvertisements { get; }
        Advertisements GetAdvertisementById(int id);
    }
}
