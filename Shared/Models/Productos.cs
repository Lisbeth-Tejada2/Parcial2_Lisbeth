using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lisbeth.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La descripcion es un campo obligatorio") ]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio") ]
        public int Tipo { get; set; } 

        [Required(ErrorMessage = "La cantidad que existen de los productos es obligatoria") ]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El precio de venta es obligatorio") ]
        public double PrecioDeCompra { get; set; }

        [Required(ErrorMessage = "El precio de compra es obligatorio") ]
        public double PrecioDeVenta { get; set; }
    }
}
