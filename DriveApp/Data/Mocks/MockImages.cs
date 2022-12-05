using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Mocks
{
    public class MockImages : IImages
    {
        public IEnumerable<Images> AllImages
        {
            get
            {
                return new List<Images> {
                    new Images {
                        filename = "Volvo XC60",
                        data =  null
                    }
                };
            }
        }

        public Images GetImageById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
