using BursUI.Entities.BursManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BursUI.Entities.BursService
{
    public class BasvuruFormManager
    {
        BasvuruFormRepository br;
        public BasvuruFormManager()
        {
            br = new BasvuruFormRepository();
        }
        public string AddBasvuru(BasvuruForm item)
        {
            try
            {
                br.Add(item);
                return "Ekleme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateBasvuru(BasvuruForm item)
        {
            try
            {
                br.Update(item);
                return "Güncelleme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteBasvuru(BasvuruForm item)
        {
            try
            {
                br.Delete(item);
                return "Silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ICollection<BasvuruForm> GetAllBasvuru(Expression<Func<BasvuruForm, bool>> parameter = null)
        {
            return br.GetAll(parameter);
        }
    }
}