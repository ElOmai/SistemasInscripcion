using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required, StringLength(maximumLength: 9, MinimumLength = 9)]
        public string Matricula { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required, Range(1,1000000)]
        public decimal Balance { get; set; }
        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
