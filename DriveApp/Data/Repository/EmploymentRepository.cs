using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class EmploymentRepository : IEmployment
    {
        private readonly AppDBContent content;
        public EmploymentRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Employment> AllEmployment => content.Employment;

        public Employment GetEmploymentById(int id) => content.Employment.FirstOrDefault(p => p.id == id);
    }
}
