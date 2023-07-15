using Microsoft.EntityFrameworkCore;
using Parcial2_Lisbeth.Shared.Models;

namespace Parcial2_Lisbeth.Server.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Productos> Productos { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData
            (
                new Productos
                {
                    ProductoId = 1,
                    Descripcion = "Mani",
                    Tipo = 0,
                    Existencia = 250,
                    PrecioDeCompra = 5,
                    PrecioDeVenta = 8
                },

                new Productos
                {
                    ProductoId = 2,
                    Descripcion = "Pistachos",
                    Tipo = 0,
                    Existencia = 300,
                    PrecioDeCompra = 15,
                    PrecioDeVenta = 18
                },

                new Productos
                {
                    ProductoId = 3,
                    Descripcion = "Pasas",
                    Tipo = 0,
                    Existencia = 130,
                    PrecioDeCompra = 5,
                    PrecioDeVenta = 8
                },

                new Productos
                {
                    ProductoId = 4,
                    Descripcion = "Ciruelas",
                    Tipo = 0,
                    Existencia = 350,
                    PrecioDeCompra = 10,
                    PrecioDeVenta = 15
                },

                new Productos
                {
                    ProductoId = 5,
                    Descripcion = "Mixto MPP 0.5Lb",
                    Tipo = 1,
                    Existencia = 320,
                    PrecioDeCompra = 30,
                    PrecioDeVenta = 35
                },

                new Productos
                {
                    ProductoId = 6,
                    Descripcion = "Mixto MPC 0.5Lb",
                    Tipo = 1,
                    Existencia = 310,
                    PrecioDeCompra = 45,
                    PrecioDeVenta = 50
                },

                new Productos
                {
                    ProductoId = 7,
                    Descripcion = "Mixto MPP 0.2Lb",
                    Tipo = 1,
                    Existencia = 250,
                    PrecioDeCompra = 20,
                    PrecioDeVenta = 29
                }
            );
        }
    }
}
