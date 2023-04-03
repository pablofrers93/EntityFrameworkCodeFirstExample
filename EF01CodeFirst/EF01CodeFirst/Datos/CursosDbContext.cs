using EF01CodeFirst.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01CodeFirst.Datos
{
    public class CursosDbContext : DbContext
    {
        public CursosDbContext()
        {

        }
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Categoria> Categorias { get; set; }

    }
}
