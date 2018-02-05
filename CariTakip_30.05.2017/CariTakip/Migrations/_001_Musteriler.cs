using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Migrations
{
    [Migration(1)]
    public class _001_Musteriler:Migration
    {

        public override void Down()
        {
            Delete.Table("Musteriler");
        }


        public override void Up()
        {
            Create.Table("Musteriler")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("tc").AsString(11).Nullable()
                .WithColumn("vergi_no").AsString(10).Nullable()
                .WithColumn("ad").AsString(50).Nullable()
                .WithColumn("soyad").AsString(50).Nullable()
                .WithColumn("firma_adi").AsString(256).Nullable()
                .WithColumn("tel").AsString(10)
                .WithColumn("email").AsString(100)
                .WithColumn("adres").AsCustom("text")
                .WithColumn("silme_tarihi").AsDateTime().Nullable();

        }
    }
}