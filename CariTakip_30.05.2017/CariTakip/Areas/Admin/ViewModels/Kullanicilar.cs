using CariTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CariTakip.Areas.Admin.ViewModels
{
    public class KullanicilarIndex
    {
        public IEnumerable<Kullanici> Kullanicilar { get; set; }

    }

   
    public class KullanicilarYeni
    {
        [Required][MaxLength(10)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(12)]
        public string Sifre { get; set; }
    }

    public class KullanicilarDuzenle
    {
        [Required]
        [MaxLength(10)]
        public string Adi { get; set; }
        
    }
    public class KullanicilarSifreDegistir
    {
        [Required]
        [MaxLength(12)]
        public string Sifre { get; set; }

    }
}