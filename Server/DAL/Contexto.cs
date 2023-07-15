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
                    PrecioCompra = 5,
                    PrecioVenta = 8
                },

                new Productos
                {
                    ProductoId = 2,
                    Descripcion = "Pistachos",
                    Tipo = 0,
                    Existencia = 300,
                    PrecioCompra = 15,
                    PrecioVenta = 18
                },

                new Productos
                {
                    ProductoId = 3,
                    Descripcion = "Pasas",
                    Tipo = 0,
                    Existencia = 130,
                    PrecioCompra = 5,
                    PrecioVenta = 8
                },

                new Productos
                {
                    ProductoId = 4,
                    Descripcion = "Ciruelas",
                    Tipo = 0,
                    Existencia = 350,
                    PrecioCompra = 10,
                    PrecioVenta = 15
                },

                new Productos
                {
                    ProductoId = 5,
                    Descripcion = "Mixto MPP 0.5Lb",
                    Tipo = 1,
                    Existencia = 320,
                    PrecioCompra = 30,
                    PrecioVenta = 35
                },

                new Productos
                {
                    ProductoId = 6,
                    Descripcion = "Mixto MPC 0.5Lb",
                    Tipo = 1,
                    Existencia = 310,
                    PrecioCompra = 45,
                    PrecioVenta = 50
                },

                new Productos
                {
                    ProductoId = 7,
                    Descripcion = "Mixto MPP 0.2Lb",
                    Tipo = 1,
                    Existencia = 250,
                    PrecioCompra = 20,
                    PrecioVenta = 29
                }
            );
        }
    }
}
