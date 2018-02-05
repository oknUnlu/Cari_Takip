using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Migrations
{
    [Migration(2)]
    public class _002_Tur_ve_OdemeSekli:Migration
    {

        public override void Down()
        {
            Delete.Table("odemeSekilleri");
            Delete.Table("turler");
        }

        public override void Up()
        {
            Create.Table("turler")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Adi").AsString(100);
            Create.Table("odemeSekilleri")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Adi").AsString(100);

        }
    }
}