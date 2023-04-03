using EF01CodeFirst.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCursos();
            Console.ReadLine();
        }

        private static void GetCursos()
        {
            using (var context = new CursosDbContext())
            {
                var listaCursos = context.Cursos.ToList();
                foreach (var curso in listaCursos)
                {
                    Console.WriteLine($"{curso.CursoId} - {curso.NombreCurso}");
                }
            }
        }
    }
}
