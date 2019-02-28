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
        MessageBoxRepository br;
        public MessageBoxManager()
        {
            br = new MessageBoxRepository();
        }
        public string AddMessage(MessageBox item)
        {
            try
            {
                br.Add(item);
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
                br.Delete(item);
                return "Silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ICollection<MessageBox> GetAllBasvuru(Expression<Func<MessageBox, bool>> parameter = null)
        {
            return br.GetAll(parameter);
        }
    }
}
