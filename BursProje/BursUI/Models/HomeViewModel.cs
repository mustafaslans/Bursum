using BursUI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BursUI.Models
{
    public class HomeViewModel
    {
        public ICollection<ApplicationUser> ApplicationUser { get; set; }
        public ICollection<ApplicationUser> ApplicationUser2 { get; set; }
    }
}