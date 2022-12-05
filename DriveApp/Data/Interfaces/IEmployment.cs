using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface IEmployment
    {
        IEnumerable<Employment> AllEmployment { get; }
        Employment GetEmploymentById(int id);
    }
}
