using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Interfaces
{
    interface ICategories
    {
        IEnumerable<Categories> AllCategories { get; }
        Categories GetCategoryById(int id);
    }
}
