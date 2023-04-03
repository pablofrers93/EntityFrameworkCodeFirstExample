﻿namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCostoNameWithPrecioFinalInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "PrecioFinal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("Update Cursos SET PrecioFinal=Costo");
            DropColumn("dbo.Cursos", "Costo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursos", "Costo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("Update Cursos SET Costo=PrecioFinal");
            DropColumn("dbo.Cursos", "PrecioFinal");
        }
    }
}
