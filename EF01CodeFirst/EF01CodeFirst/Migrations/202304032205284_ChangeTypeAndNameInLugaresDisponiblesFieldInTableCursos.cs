namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeAndNameInLugaresDisponiblesFieldInTableCursos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Vacantes", c => c.Byte(nullable: false));
            Sql("Update Cursos SET Vacantes=LugaresDisponibles");
            DropColumn("dbo.Cursos", "LugaresDisponibles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursos", "LugaresDisponibles", c => c.Int(nullable: false));
            Sql("Update Cursos SET LugaresDisponibles=Vacantes");
            DropColumn("dbo.Cursos", "Vacantes");
        }
    }
}
