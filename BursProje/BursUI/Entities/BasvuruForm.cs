using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BursUI.Entities
{
    public class BasvuruForm
    {
        [Key]
        public int BasvuruFormID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string TcNo { get; set; }
        [Required]
        public string AnneAdi { get; set; }
        [Required]
        public string BabaAdi { get; set; }
        [Required]
        public string AileAylik { get; set; }
        [Required]
        public string Okul { get; set; }
        [Required]
        public string Bolum { get; set; }
        [Required]
        public string NotOrtalaması { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
    }
}