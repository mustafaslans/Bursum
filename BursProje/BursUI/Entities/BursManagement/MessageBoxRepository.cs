using BursUI.Entities.Repository;
using BursUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BursUI.Entities.BursManagement
{
    public class MessageBoxRepository : IMessageBox
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
            throw new NotImplementedException();
        }

        public void Update(MessageBox item)
        {
            throw new NotImplementedException();
        }
    }
}