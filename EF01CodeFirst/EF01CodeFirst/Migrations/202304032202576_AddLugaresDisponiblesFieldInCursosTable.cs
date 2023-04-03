namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLugaresDisponiblesFieldInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "LugaresDisponibles", c => c.Int(nullable: false));
            Sql("Update Cursos SET LugaresDisponibles=20");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "LugaresDisponibles");
        }
    }
}
