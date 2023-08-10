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
    [Migration("20230810133122_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Models.Entradas", b =>
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

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Models.EntradasDetalle", b =>
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

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PrecioDeCompra")
                        .HasColumnType("REAL");

                    b.Property<double>("PrecioDeVenta")
                        .HasColumnType("REAL");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripcion = "Mani",
                            Existencia = 250,
                            PrecioDeCompra = 8.0,
                            PrecioDeVenta = 15.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripcion = "Pistachos",
                            Existencia = 300,
                            PrecioDeCompra = 15.0,
                            PrecioDeVenta = 30.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripcion = "Pasas",
                            Existencia = 130,
                            PrecioDeCompra = 10.0,
                            PrecioDeVenta = 25.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripcion = "Ciruelas",
                            Existencia = 350,
                            PrecioDeCompra = 25.0,
                            PrecioDeVenta = 50.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripcion = "Mixto MPP",
                            Existencia = 320,
                            PrecioDeCompra = 30.0,
                            PrecioDeVenta = 60.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 6,
                            Descripcion = "Mixto MPC",
                            Existencia = 310,
                            PrecioDeCompra = 30.0,
                            PrecioDeVenta = 60.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 7,
                            Descripcion = "Mixto MPP",
                            Existencia = 250,
                            PrecioDeCompra = 25.0,
                            PrecioDeVenta = 50.0,
                            Tipo = 0
                        });
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Models.EntradasDetalle", b =>
                {
                    b.HasOne("Parcial2_Lisbeth.Shared.Models.Entradas", null)
                        .WithMany("entradasDetalle")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial2_Lisbeth.Shared.Models.Entradas", b =>
                {
                    b.Navigation("entradasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}