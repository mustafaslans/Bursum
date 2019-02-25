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
        public ActionResult Index()
        {
            return View();
        }
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Hersey()
        {  
            return View(db.Users.ToList());
        }
        public ActionResult Burslar()
        {
            return View(db.Users.ToList());
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