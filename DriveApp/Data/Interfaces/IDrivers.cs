using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    public interface IDrivers
    {
        IEnumerable<Drivers> AllDrivers { get; }
        Drivers GetDriverById(int id);
    }
}
