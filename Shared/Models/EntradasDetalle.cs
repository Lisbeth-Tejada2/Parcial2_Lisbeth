using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lisbeth.Shared.Models
{
    public class EntradasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int EntradaId { get; set; }

        [Required(ErrorMessage = "Es ProductoId es un campo obligatorio") ]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La cantidad utilizada es obligatoria")]
        public int CantidadUtilizada { get; set; }
    }
}
