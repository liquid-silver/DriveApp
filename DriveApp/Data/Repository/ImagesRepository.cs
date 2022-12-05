using DriveApp.Data.Interfaces;
using DriveApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Data.Repository
{
    public class ImagesRepository : IImages
    {
        private readonly AppDBContent content;
        public ImagesRepository(AppDBContent content)
        {
            this.content = content;
        }

        public IEnumerable<Images> AllImages => content.Images;

        public Images GetImageById(int id) => content.Images.FirstOrDefault(p => p.id == id);
    }
}
