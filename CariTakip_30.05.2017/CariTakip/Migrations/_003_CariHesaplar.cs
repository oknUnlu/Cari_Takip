using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Migrations
{
    [Migration(3)]
    public class _003_CariHesaplar:Migration
    {
        public override void Down()
        {
            Delete.Table("CariHesaplar");
        }

        public override void Up()
        {
            Create.Table("CariHesaplar")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("tarih").AsDateTime()
                .WithColumn("aciklama").AsCustom("text")
                .WithColumn("girilen_miktar").AsDouble()
                .WithColumn("cikan_miktar").AsDouble()
                .WithColumn("tur_id").AsInt32().ForeignKey("turler", "id")
                .WithColumn("odeme_id").AsInt32().ForeignKey("odemeSekilleri", "id")
                .WithColumn("musteri_id").AsInt32().ForeignKey("musteriler", "id");
        }
    }
}