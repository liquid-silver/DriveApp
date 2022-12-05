using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockCategories : ICategories
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories> { 
                    new Categories { name = "Стандарт"},
                    new Categories { name = "Бизнес"},
                    new Categories { name = "Представительский"},
                    new Categories { name = "Минивэн"},
                    new Categories { name = "Микроавтобус"},
                    new Categories { name = "Автобус"},
                    new Categories { name = "Газель"},
                    new Categories { name = "Фура"}
                };
            }
        }

        public Categories GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
