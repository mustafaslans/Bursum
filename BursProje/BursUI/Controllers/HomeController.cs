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
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Hersey()
        {  
            return View(db.Users.ToList());
        }
        public ActionResult Burslar()
        {
            return View(db.Users.ToList());
        }
        public ActionResult Ogrenciler()
        {
            return View(db.Users.ToList());
        }
        [HttpGet]
        public ActionResult BasvuruCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BasvuruCreate(int basvurulanid)
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }       
    }
}