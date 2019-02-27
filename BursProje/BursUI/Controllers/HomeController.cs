using BursUI.Entities;
using BursUI.Entities.BursService;
using BursUI.Models;
using Microsoft.AspNet.Identity;
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
        BasvuruFormManager bfm;
        public HomeController()
        {
            db = new ApplicationDbContext();
            bfm = new BasvuruFormManager();
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
            return View(db.Users.Where(x => x.BursRole == "BursVeren").ToList());
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
        [ValidateAntiForgeryToken]
        public ActionResult BasvuruCreate(string Id, BasvuruForm bf)
        {
            string basvuranid = User.Identity.GetUserId();
            bf.BasvuranID = basvuranid;
            bf.BasvurulanID = Id;
            bfm.AddBasvuru(bf);
            return View();
        }
        public ActionResult ProfilBursAlan()
        {
            string id = User.Identity.GetUserId();
            var result = (from a in db.BasvuruForms
                          join b in db.Users on a.BasvurulanID equals b.Id
                          where a.BasvuranID == id 
                          select new ProfilBursAlanViewModel
                          {
                              Ad = b.Ad,
                              Soyad = b.Soyad,
                              Email = b.Email,
                              BasvuruID = a.BasvuruFormID
                          }).ToList();            
            return View(result.ToList());
        }
        public ActionResult ProfilBursVeren()
        {
            string id2 = User.Identity.GetUserId();
            var result = (from a in db.BasvuruForms
                          join b in db.Users on a.BasvuranID equals b.Id
                          where b.Id == id2
                          select a).ToList();
            return View(result.ToList());
        }
        [HttpPost]
        public JsonResult Getir(string id)
        {
            ApplicationUser ad = db.Users.Where(x => x.Id == id).FirstOrDefault();
            return Json(ad);
        }
    }
}