using BursUI.Entities.BursService;
using BursUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BursUI.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel();
            hm.ApplicationUser = db.Users.Where(x => x.BursRole == "BursAlan").ToList();
            hm.ApplicationUser2 = db.Users.Where(x => x.BursRole == "BursVeren").ToList();
            return View(hm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}