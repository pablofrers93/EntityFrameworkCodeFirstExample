using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01CodeFirst.Entidades
{
    [Table("Cursos")]
    public class Curso
    {
        public int CursoId { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreCurso { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
        
        public decimal Costo{ get; set; }
    }
}
