namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createInitialCatalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        NombreCurso = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cursos");
        }
    }
}
