using BursUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BursUI.Entities
{
    public class MessageBox
    {
        public int MessageboxID { get; set; }
        public ApplicationUser MesajAtan { get; set; }
        public ApplicationUser MesajAlan { get; set; }
        public string Mesaj { get; set; }
    }
}