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
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El tipo es obligatorio") ]
        public int Tipo { get; set; } 

        [Required(ErrorMessage = "Es necesario especifcar la cantidad de productos que existen") ]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El precio de venta es obligatorio") ]
        public double PrecioCompra { get; set; }

        [Required(ErrorMessage = "El precio de compra es obligatorio") ]
        public double PrecioVenta { get; set; }
    }
}
