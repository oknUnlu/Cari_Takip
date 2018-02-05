using CariTakip.InfraStructure;
using CariTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CariTakip.ViewModels
{
    public class MusterilerIndex
    {

        public IEnumerable<Musteri> Musteriler { get; set; }
  
    }
    public class MusterilerYeni
    {
        
        [MaxLength(11)]
        [MinLength(11)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen Tc alanına sadece rakamla yazınız.")]
        public string Tc { get; set; }
        [MaxLength(10)]
        [MinLength(10)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen VergiNo alanına sadece harfle yazınız.")]
        public string VergiNo { get; set; }
        [MaxLength(50)]
      
        public string Ad { get; set; }
        [MaxLength(50)]

        public string Soyad { get; set; }
        [MaxLength(256)]
       
        public string FirmaAdi { get; set; }
       
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen Telefon alanına sadece rakamla yazınız.")] 
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [MinLength(10)]
        public string Tel { get; set; }
        [MaxLength(100)]
  
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Adres { get; set; }
    

    }
    public class MusterilerDuzenle
    {
        [MaxLength(11)]
        [MinLength(11)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen Tc alanına sadece rakamla yazınız.")]
        public string Tc { get; set; }
        [MaxLength(10)]
        [MinLength(10)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen VergiNo alanına sadece harfle yazınız.")]
        public string VergiNo { get; set; }
        [MaxLength(50)]
   
        public string Ad { get; set; }
        [MaxLength(50)]
       
        public string Soyad { get; set; }
        [MaxLength(256)]
        public string FirmaAdi { get; set; }
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Lütfen Telefon alanına sadece rakamla yazınız.")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [MinLength(10)]
        public string Tel { get; set; }
        [MaxLength(100)]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Adres { get; set; }
        
     

    }

    public class KasaIndex
    {

        public PagedData<CariHesap> CariHesap { get; set; }
        public double GirenMiktar { get; set; }
        public double CikanMiktar { get; set; }
        public double KalanMiktar { get; set; }
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
    
        public IEnumerable<CariHesap> CariHesaplar { get; set; }
    }
    public class KasaYeni
    {
    
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Tarih { get; set; }
         [Required]
        public string Aciklama { get; set; }

        [Required]
        public double GirilenMiktar { get; set; }
        [Required]
        public double CikanMiktar { get; set; }

        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
    
    }
    public class KasaDuzenle
    {
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Tarih { get; set; }
        [Required]
        public string Aciklama { get; set; }

        [Required]
        public double GirilenMiktar { get; set; }
        [Required]
        public double CikanMiktar { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public int MusteriID { get; set; }


    }
}