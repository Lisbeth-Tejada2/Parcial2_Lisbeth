using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lisbeth.Shared
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public string Concepto { get; set; } = string.Empty;
        public int PesoTotal { get;set; }

        [ForeignKey("EntradaId")]
        public virtual List<EntradasDetalle> EntradasDetalle { get; set; } = new List<EntradasDetalle>();
        public int ProductoId { get; set; }
        public int CantidadProducida { get; set; }

    }
}
