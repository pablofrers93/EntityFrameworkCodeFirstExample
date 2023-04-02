namespace EF01CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCursosTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Cursos (NombreCurso, Descripcion) VALUES ('C# Basico', 'Primeros pasos con el lenguaje')");
            Sql("Insert into Cursos (NombreCurso, Descripcion) VALUES ('C# Intermedio', '')");
            Sql("Insert into Cursos (NombreCurso, Descripcion) VALUES ('C# Avanzado', 'Tecnicas avanzadas de programación')");
        }
        
        public override void Down()
        {
            Sql("Delete from Cursos");
        }
    }
}
