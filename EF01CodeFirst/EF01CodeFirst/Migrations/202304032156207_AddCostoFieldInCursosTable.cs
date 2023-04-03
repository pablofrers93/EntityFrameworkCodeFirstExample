namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCostoFieldInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Costo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            Sql("Update Cursos SET Costo=15000");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "Costo");
        }
    }
}
