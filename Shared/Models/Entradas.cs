using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Parcial2_Lisbeth.Shared.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El concepto es obligatorio")]
        public string? Concepto { get; set; }
        [Required(ErrorMessage = "El Producto ID es un campo obligatorio")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es necesario especificar la cantidad que se utilizo")]
        public int CantidadProducida { get; set; }

        [ForeignKey("EntradaId")]
        public List<EntradasDetalle> entradasDetalle { get; set; } = new List<EntradasDetalle>();

    }
    public class EntradasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int EntradaId { get; set; }

        [Required(ErrorMessage = "Es Producto ID es un campo obligatorio")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es necesario especificar la cantidad utilizada")]
        public int CantidadUtilizada { get; set; }
    }
}
