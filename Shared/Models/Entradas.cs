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
        public DateTime Fecha { get; set; } = DateTime.Today;

        [Required(ErrorMessage ="El concepto es obligatorio") ]
        public string Concepto { get; set; } = string.Empty;
        public int PesoTotal { get; set; }

        [ForeignKey("EntradaId")] 
        public List<EntradasDetalle> entradasDetalle { get; set; } = new List<EntradasDetalle>();
        
        [Required(ErrorMessage = "El ProductodId obligatorio")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La cantidad utilizada es obligatoria")]
        public int CantidadProducida { get; set; }

    }
}
