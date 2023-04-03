namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVigenteFieldInTableCursos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Vigente", c => c.Boolean(nullable: false));
            Sql("Update Cursos SET Vigente=1");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "Vigente");
        }
    }
}
