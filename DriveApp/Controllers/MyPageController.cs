using DriveApp.Data;
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
        private readonly AppDBContent content;
        public MyPageController(IDrivers drivers, AppDBContent content)
        {
            this.drivers = drivers;
            this.content = content;
        }

        //public IActionResult Edit(int id)
        //{
        //    return ControllerContext.MyDisplayRouteInfo(id);
        //}

        //public void primer(string[] args)
        //{
        //    var context = new SchoolContext();
        //    var studentsWithSameName = context.Students
        //                                      .Where(s => s.FirstName == GetName())
        //                                      .ToList();
        //}

        //public static string GetName()
        //{
        //    return "Bill";
        //}
        public ViewResult Index()
        {
            //var mypage = drivers.GetDriverById();
            return View();
        }
    }
}
