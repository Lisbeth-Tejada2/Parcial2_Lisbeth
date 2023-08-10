using Microsoft.EntityFrameworkCore;
using Parcial2_Lisbeth.Shared.Models;

namespace Parcial2_Lisbeth.Server.DAL
{
    public class Context : DbContext
    {
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Productos> Productos { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData
            (
                new Productos
                {
                    ProductoId = 1,
                    Descripcion = "Mani",
                    PrecioDeCompra = 8,
                    PrecioDeVenta = 15,
                    Existencia = 250
                },

                new Productos
                {
                    ProductoId = 2,
                    Descripcion = "Pistachos",
                    PrecioDeCompra = 15,
                    PrecioDeVenta = 30,
                    Existencia = 300
                },

                new Productos
                {
                    ProductoId = 3,
                    Descripcion = "Pasas",
                    PrecioDeCompra = 10,
                    PrecioDeVenta = 25,
                    Existencia = 130
                },

                new Productos
                {
                    ProductoId = 4,
                    Descripcion = "Ciruelas",
                    PrecioDeCompra = 25,
                    PrecioDeVenta = 50,
                    Existencia = 350
                },

                new Productos
                {
                    ProductoId = 5,
                    Descripcion = "Mixto MPP",
                    PrecioDeCompra = 30,
                    PrecioDeVenta = 60,
                    Existencia = 320
                },

                new Productos
                {
                    ProductoId = 6,
                    Descripcion = "Mixto MPC",
                    PrecioDeCompra = 30,
                    PrecioDeVenta = 60,
                    Existencia = 310
                },

                new Productos
                {
                    ProductoId = 7,
                    Descripcion = "Mixto MPP",
                    PrecioDeCompra = 25,
                    PrecioDeVenta = 50,
                    Existencia = 250
                }
            );
        }
    }
}