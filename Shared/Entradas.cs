using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lisbeth.Shared
{
    internal class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; } = string.Empty;
        [ForeignKey("EntradaId")]
        public virtual List<EntradasProductosDetalle> EntradasProductosDetalle { get; set; } = new List<EntradasProductosDetalle ();

    }
}
