using System;
using System.ComponentModel.DataAnnotations;

namespace OtoYikamaMusteriTakibi.Models
{
    public class Musteri
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Required]
        [Display(Name = "Plaka")]
        public string Plaka { get; set; }
        
        [Required]
        [Display(Name = "Hizmet")]
        public string Hizmet { get; set; }

        [Display(Name = "Hizmet Tarihi")]
        public DateTime HizmetTarihi { get; set; }
    }
}
