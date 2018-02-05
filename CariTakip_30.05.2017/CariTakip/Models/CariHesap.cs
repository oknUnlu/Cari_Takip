using CariTakip.Migrations;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Models
{
    public class CariHesap
    {
        public virtual int Id { get; set; }
        public virtual DateTime Tarih {get;set;}
        public virtual string Aciklama { get; set; }
        public virtual double GirilenMiktar { get; set; }
        public virtual double CikanMiktar { get; set; }

        public virtual Tur Tur { get; set; }
        public virtual OdemeSekli OdemeSekli { get; set; }
        public virtual Musteri Musteri { get; set; }
        public CariHesap()
        {
            Tur = new Tur();
            OdemeSekli = new OdemeSekli();
            Musteri = new Musteri();
        }
    }

    public class CariHesapMap : ClassMapping<CariHesap>
    {
        public CariHesapMap()
        {
            Table("carihesaplar");
            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Tarih, x => x.NotNullable(true));
            Property(x => x.Aciklama, x => x.NotNullable(true));
            Property(x => x.GirilenMiktar, x => 
            {
                x.Column("girilen_miktar");
                x.NotNullable(true);
            });
            Property(x => x.CikanMiktar, x =>
            {
                x.Column("cikan_miktar");
                x.NotNullable(true);
            });
         

            ManyToOne(x => x.Tur, x =>
            {
                x.Column("tur_id");
                x.NotNullable(true);

            });
            ManyToOne(x => x.OdemeSekli, x =>
            {
                x.Column("odeme_id");
                x.NotNullable(true);

            });
            ManyToOne(x => x.Musteri, x =>
            {
                x.Column("musteri_id");
                x.NotNullable(true);

            });
        }
    }
}