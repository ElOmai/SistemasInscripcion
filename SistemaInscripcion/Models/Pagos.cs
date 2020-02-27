using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        [Required, Range(typeof(DateTime), minimum: "1/1/2000", maximum: "1/1/2025")]
        public DateTime Fecha { get; set; }
        [Required]
        public int InscripcionId { get; set; }
        [Required, Range(0, 1000000)]
        public decimal Monto { get; set; }


        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            InscripcionId = 0;
            Monto = 0;
        }
    }
}
