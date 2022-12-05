using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface IImages
    {
        IEnumerable<Images> AllImages { get;  }
        Images GetImageById(int id);
    }
}
