using DriveApp.Data.Interfaces;
using DriveApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Controllers
{
    public class AdvertisementsController : Controller
    {
        private readonly IAdvertisements advertisements;
        private readonly IVehicles vehicles;

        public AdvertisementsController(IAdvertisements advertisements, IVehicles vehicles)
        {
            this.advertisements = advertisements;
            this.vehicles = vehicles;
        }
        public ViewResult List()
        {
            //ViewBag.Category = "Some New";
            //var ad = advertisements.AllAdvertisements;
            ViewBag.Title = "Страниица с объявлениями";
            AdvertisementsListViewModel advertisementsListViewModel = new AdvertisementsListViewModel();
            advertisementsListViewModel.GetAdvertisements = advertisements.AllAdvertisements;
            advertisementsListViewModel.currVehicle = "Объявления";
            return View(advertisementsListViewModel);
        }
    }
}
