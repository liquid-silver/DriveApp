using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class AdvertisementsRepository : IAdvertisements
    {
        private readonly AppDBContent content;
        public AdvertisementsRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Advertisements> AllAdvertisements => content.Advertisements;
        //public IEnumerable<Advertisements> AllAdvertisements => content.Advertisements.Where(p => p.priceInside > 100).Include(c => c.category);

        public Advertisements GetAdvertisementById(int id) => content.Advertisements.FirstOrDefault(p => p.id == id);
    }
}
