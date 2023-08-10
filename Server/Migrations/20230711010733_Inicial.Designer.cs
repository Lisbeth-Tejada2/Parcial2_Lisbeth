﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2_Lisbeth.Server.DAL;

#nullable disable

namespace Parcial2_Lisbeth.Server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230711010733_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Entradas", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadProducida")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PesoTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.EntradasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadUtilizada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EntradaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("EntradaId");

                    b.ToTable("EntradasDetalle");
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Tipo")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripcion = "Maní",
                            Existencia = 50,
                            Tipo = 0f
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripcion = "Pistachos",
                            Existencia = 600,
                            Tipo = 0f
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripcion = "Pasas",
                            Existencia = 500,
                            Tipo = 0f
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripcion = "Ciruelas",
                            Existencia = 700,
                            Tipo = 0f
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripcion = "Mixto MPP 0.5LB",
                            Existencia = 0,
                            Tipo = 1f
                        },
                        new
                        {
                            ProductoId = 6,
                            Descripcion = "Mixto MPPC 0.5LB",
                            Existencia = 0,
                            Tipo = 1f
                        },
                        new
                        {
                            ProductoId = 7,
                            Descripcion = "Mixto MPPC 0.2LB",
                            Existencia = 0,
                            Tipo = 1f
                        });
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.EntradasDetalle", b =>
                {
                    b.HasOne("Parcial2_Lisbeth.Shared.Entradas", null)
                        .WithMany("EntradasDetalle")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Entradas", b =>
                {
                    b.Navigation("EntradasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
