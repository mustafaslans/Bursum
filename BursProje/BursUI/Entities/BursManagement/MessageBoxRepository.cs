using BursUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BursUI.Entities.BursManagement
{
    public class MessageBoxRepository
    {
        ApplicationDbContext db;
        public MessageBoxRepository()
        {
            db = new ApplicationDbContext();
        }

        public void Add(MessageBox item)
        {
            db.MessageBoxes.Add(item);
            db.SaveChanges();
        }

        public void Delete(MessageBox item)
        {
            db.MessageBoxes.Remove(item);
            db.SaveChanges();
        }

        public ICollection<MessageBox> GetAll(Expression<Func<MessageBox, bool>> paramater = null)
        {
            return paramater == null ?
                 db.MessageBoxes.ToList() :
                 db.MessageBoxes.Where(paramater).ToList();
        }

        public void Update(MessageBox item)
        {
            db.SaveChanges();
        }
    }
}