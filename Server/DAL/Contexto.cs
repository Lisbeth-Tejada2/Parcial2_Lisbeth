using Microsoft.EntityFrameworkCore;
using Parcial2_Lisbeth.Shared;

namespace Parcial2_Lisbeth.Server.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Entradas> Entradas { get; set; }
        public Contexto(DbContextOptions<Contexto> options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Productos>().HasData(
                    new Productos
                    {
                        ProductoId = 1,
                        Descripcion = "Maní",
                        Tipo = 0,
                        Existencia = 50
                    },

                    new Productos
                    {
                        ProductoId = 2,
                        Descripcion = "Pistachos",
                        Tipo = 0,
                        Existencia = 600  
                    },

                    new Productos
                    {
                        ProductoId = 3,
                        Descripcion = "Pasas",
                        Tipo = 0,
                        Existencia = 500
                    },

                    new Productos
                    {
                        ProductoId = 4,
                        Descripcion = "Ciruelas",
                        Tipo = 0,
                        Existencia = 700
                    },

                    new Productos
                    {
                        ProductoId = 5,
                        Descripcion = "Mixto MPP 0.5LB",
                        Tipo = 1,
                        Existencia = 0
                    },

                    new Productos 
                    {
                        ProductoId = 6,
                        Descripcion = "Mixto MPPC 0.5LB",
                        Tipo = 1,
                        Existencia = 0
                    },

                    new Productos 
                    {
                        ProductoId = 7,
                        Descripcion = "Mixto MPPC 0.2LB",
                        Tipo = 1,
                        Existencia = 0
                    }

                );
            }
        }
    }
}
