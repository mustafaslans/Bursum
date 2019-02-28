using BursUI.Entities;
using BursUI.Entities.BursManagement;
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
        MessageBoxManager mbm;
        public HomeController()
        {
            db = new ApplicationDbContext();
            bfm = new BasvuruFormManager();
            mbm = new MessageBoxManager();
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
        public ActionResult BasvuruCreate(string id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BasvuruCreate(BasvuruForm bf, string id)
        {
            string basvuranid = User.Identity.GetUserId();
            bf.BasvuranID = basvuranid;
            bf.BasvurulanID = id;
            bfm.AddBasvuru(bf);
            return RedirectToAction("Burslar");
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
                          where a.BasvurulanID == id2
                          select a).ToList();
            return View(result.ToList());
        }
        public ActionResult Detaylar(int id)
        {
            BasvuruForm bf = db.BasvuruForms.Find(id);
            return PartialView(bf);
        }
        [HttpGet]
        public ActionResult MessageCreate(string id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MessageCreate(string id, MessageBox mb)
        {
            string id2 = User.Identity.GetUserId();
            mb.MesajAlanID = id;
            mb.MesajAtanID = id2;
            mbm.AddMessage(mb);
            return View();
        }
    }
}