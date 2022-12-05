using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface ITrucks
    {
        IEnumerable<Trucks> AllTrucks { get; }
        Trucks GetTruckById(int id);
    }
}
