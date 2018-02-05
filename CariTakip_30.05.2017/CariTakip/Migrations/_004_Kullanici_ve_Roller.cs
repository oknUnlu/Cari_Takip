using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Migrations
{
    [Migration(4)]
    public class _004_Kullanici_ve_Roller:Migration
    {
        public override void Down()
        {
             Delete.Table("kullanicilar");
             Delete.Table("roller");
        }

        public override void Up()
        {

            Create.Table("roller")
                 .WithColumn("id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("adi").AsString(128);
            Create.Table("kullanicilar")
                   .WithColumn("id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("adi").AsString(128)
                   .WithColumn("sifre").AsString(256)
                    .WithColumn("rol_id").AsInt32().ForeignKey("roller", "id");
        }
    }
}