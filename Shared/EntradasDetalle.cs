using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lisbeth.Shared
{
    public class EntradasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public int CantidadUtilizada { get; set; }
    }
}
