namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategoriasTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        NombreCategoria = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoriaId)
                .Index(t => t.NombreCategoria, unique: true, name: "IX_Categorias_NombreCategoria");
            Sql("Insert INTO Categorias VALUES('Programacion')");
            Sql("Insert INTO Categorias VALUES('Desarrollo Web')");
            Sql("Insert INTO Categorias VALUES('Diseño Gráfico')");

        }

        public override void Down()
        {
            DropIndex("dbo.Categorias", "IX_Categorias_NombreCategoria");
            DropTable("dbo.Categorias");
        }
    }
}
