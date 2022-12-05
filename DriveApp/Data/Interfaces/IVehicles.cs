using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    public interface IVehicles
    {
        IEnumerable<Vehicles> AllVehicles { get; }
        IEnumerable<Vehicles> CategoryVehicles { get; }
        Vehicles GetVehicleById(int id);
    }
}
