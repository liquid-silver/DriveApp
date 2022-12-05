using DriveApp.Data.Interfaces;
using DriveApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveApp.Controllers
{
    public class MyPageController : Controller
    {
        private readonly IDrivers drivers;
        public MyPageController(IDrivers drivers)
        {
            this.drivers = drivers;
        }

        //public IActionResult Edit(int id)
        //{
        //    return ControllerContext.MyDisplayRouteInfo(id);
        //}

        public ViewResult Index()
        {
            //var mypage = drivers.GetDriverById();
            return View();
        }
    }
}
