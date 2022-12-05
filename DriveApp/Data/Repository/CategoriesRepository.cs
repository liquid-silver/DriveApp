using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class CategoriesRepository : ICategories
    {
        private readonly AppDBContent content;
        public CategoriesRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Categories> AllCategories => content.Categories;

        public Categories GetCategoryById(int id) => content.Categories.FirstOrDefault(p => p.id == id);
    }
}
