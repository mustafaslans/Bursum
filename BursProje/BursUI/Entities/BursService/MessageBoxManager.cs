using BursUI.Entities.BursManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BursUI.Entities.BursService
{
    public class MessageBoxManager
    {
        MessageBoxRepository mr;
        public MessageBoxManager()
        {
            mr = new MessageBoxRepository();
        }
        public string AddMessage(MessageBox item)
        {
            try
            {
                mr.Add(item);
                return "Gönderildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteMessage(MessageBox item)
        {
            try
            {
                mr.Delete(item);
                return "Silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ICollection<MessageBox> GetAllBasvuru(Expression<Func<MessageBox, bool>> parameter = null)
        {
            return mr.GetAll(parameter);
        }
    }
}
