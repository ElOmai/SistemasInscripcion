using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required, StringLength(maximumLength: 7, MinimumLength = 6)]
        public string Semestre { get; set; }
        [Required, Range(1, 100)]
        public int Limite { get; set; }
        [Required, Range(1, 100)]
        public int Tomados { get; set; }
        [Required, Range(0, 100)]
        public int Disponibles { get; set; }
        [Required, Range(typeof(DateTime), minimum: "1/1/2000", maximum: "1/1/2025")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es necesario ingresar el Id del estudiante")]
        public int EstudianteId { get; set; }
        [Required, Range(0, 1000000)]
        public decimal Monto { get; set; }
        [Required, Range(0, 1000000)]
        public decimal Balance { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Monto = 0;
            Balance = 0;
        }
    }
}
