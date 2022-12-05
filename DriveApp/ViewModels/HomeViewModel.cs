using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Advertisements> ads { get; set; }
    }
}
