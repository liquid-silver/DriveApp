using DriveApp.Data.Interfaces;
using DriveApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Controllers
{
    public class HomeController : Controller
    {
        private IAdvertisements advertisements;
        public HomeController(IAdvertisements advertisements)
        {
            this.advertisements = advertisements;
        }

        public ViewResult Index()
        {
            var homeAds = new HomeViewModel {
                ads = advertisements.AllAdvertisements
            };
            return View(homeAds);
        }
    }
}
