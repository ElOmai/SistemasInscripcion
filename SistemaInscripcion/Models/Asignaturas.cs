using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required , StringLength(maximumLength: 99)]
        public string Descripcion { get; set; }
        [Required]
        public string PreRequisito { get; set; }
        [Required, Range(1,10)]
        public int Creditos { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisito = string.Empty;
            Creditos = 0;
        }
    }
}
