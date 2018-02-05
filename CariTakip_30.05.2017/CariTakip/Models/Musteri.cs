using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Models
{
    public class Musteri
    {
        public virtual int Id { get; set; }
        public virtual string Tc { get; set; }
        public virtual string VergiNo { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string FirmaAdi { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Email { get; set; }
        public virtual string Adres { get; set; }
        public virtual DateTime? SilmeTarihi { get; set; }
        public virtual bool SilindiMi { get { return SilmeTarihi != null; } }
        
    }
    public class MusteriMap : ClassMapping<Musteri>
    {
        public MusteriMap()
        {
            Table("Musteriler");
            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Tc);
            Property(x => x.VergiNo,x=>x.Column("vergi_no"));
            Property(x => x.Ad,x=>x.NotNullable(true));
            Property(x => x.Soyad, x => x.NotNullable(true));
            Property(x => x.FirmaAdi, x =>x.Column("firma_adi"));
            Property(x => x.Tel, x => x.NotNullable(true));
            Property(x => x.Email, x => x.NotNullable(true));
            Property(x => x.Adres, x => x.NotNullable(true));
            Property(x => x.SilmeTarihi, x => x.Column("silme_tarihi"));
        }
    }
}