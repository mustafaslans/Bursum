using BursUI.Entities.Repository;
using BursUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BursUI.Entities.BursManagement
{
    public class BasvuruFormRepository : IBasvuruForm
    {
        ApplicationDbContext db;
        public BasvuruFormRepository()
        {
            db = new ApplicationDbContext();
        }

        public void Add(BasvuruForm item)
        {
            db.BasvuruForms.Add(item);
            db.SaveChanges();
        }

        public void Delete(BasvuruForm item)
        {
            db.BasvuruForms.Remove(item);
            db.SaveChanges();
        }

        public ICollection<BasvuruForm> GetAll(Expression<Func<BasvuruForm, bool>> paramater = null)
        {
            return paramater == null ?
                 db.BasvuruForms.ToList() :
                 db.BasvuruForms.Where(paramater).ToList();
        }

        public void Update(BasvuruForm item)
        {
            BasvuruForm eskibasvuru = db.BasvuruForms.Find(item.BasvuruFormID);
            eskibasvuru.BasvuruFormID = item.BasvuruFormID;
            eskibasvuru.Ad = item.Ad;
            eskibasvuru.Soyad = item.Soyad;
            eskibasvuru.DogumTarihi = item.DogumTarihi;
            eskibasvuru.TcNo = item.TcNo;
            eskibasvuru.Telefon = item.Telefon;
            eskibasvuru.AnneAdi = item.AnneAdi;
            eskibasvuru.BabaAdi = item.BabaAdi;
            eskibasvuru.AileAylik = item.AileAylik;
            eskibasvuru.Okul = item.Okul;
            eskibasvuru.Bolum = item.Bolum;
            eskibasvuru.NotOrtalaması = item.NotOrtalaması;
            eskibasvuru.Email = item.Email;
            db.SaveChanges();
        }
    }
}