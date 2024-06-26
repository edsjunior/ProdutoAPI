﻿// <auto-generated />
using System;
using G64.PedidoAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace G64.PedidoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240523133756_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("G64.PedidoAPI.Models.ItemPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("PrecoUnitario")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ItensPedidos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("231811de-bdfe-474b-bc51-10e3ac3251e6"),
                            Descricao = "Combo Whopper",
                            PrecoUnitario = 15.99m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = new Guid("b35e4a7a-5cfc-47f1-834a-d0e725903870"),
                            Descricao = "Coca-cola",
                            PrecoUnitario = 5.99m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = new Guid("08c34cea-4933-4a5f-891f-b2269b048ea4"),
                            Descricao = "Batata Frita",
                            PrecoUnitario = 7.99m,
                            Quantidade = 1
                        },
                        new
                        {
                            Id = new Guid("62e9b1d1-f2fc-45b2-a398-08696e63d439"),
                            Descricao = "Sorvete",
                            PrecoUnitario = 9.99m,
                            Quantidade = 2
                        });
                });

            modelBuilder.Entity("G64.PedidoAPI.Models.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1eaf06ff-0d39-49c4-bb89-d4db583da720"),
                            Data = new DateTime(2024, 5, 23, 10, 37, 55, 865, DateTimeKind.Local).AddTicks(8375),
                            Status = 0,
                            Total = 29.97m
                        },
                        new
                        {
                            Id = new Guid("4572888d-aebb-4405-a72f-3225953ab60c"),
                            Data = new DateTime(2024, 5, 23, 10, 37, 55, 865, DateTimeKind.Local).AddTicks(8388),
                            Status = 0,
                            Total = 19.98m
                        });
                });

            modelBuilder.Entity("PedidoItemPedido", b =>
                {
                    b.Property<Guid>("PedidosId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ItemPedidosId")
                        .HasColumnType("char(36)");

                    b.HasKey("PedidosId", "ItemPedidosId");

                    b.HasIndex("ItemPedidosId");

                    b.ToTable("PedidoItemPedido");

                    b.HasData(
                        new
                        {
                            PedidosId = new Guid("1eaf06ff-0d39-49c4-bb89-d4db583da720"),
                            ItemPedidosId = new Guid("231811de-bdfe-474b-bc51-10e3ac3251e6")
                        },
                        new
                        {
                            PedidosId = new Guid("1eaf06ff-0d39-49c4-bb89-d4db583da720"),
                            ItemPedidosId = new Guid("b35e4a7a-5cfc-47f1-834a-d0e725903870")
                        },
                        new
                        {
                            PedidosId = new Guid("1eaf06ff-0d39-49c4-bb89-d4db583da720"),
                            ItemPedidosId = new Guid("08c34cea-4933-4a5f-891f-b2269b048ea4")
                        },
                        new
                        {
                            PedidosId = new Guid("4572888d-aebb-4405-a72f-3225953ab60c"),
                            ItemPedidosId = new Guid("62e9b1d1-f2fc-45b2-a398-08696e63d439")
                        });
                });

            modelBuilder.Entity("PedidoItemPedido", b =>
                {
                    b.HasOne("G64.PedidoAPI.Models.ItemPedido", null)
                        .WithMany()
                        .HasForeignKey("ItemPedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("G64.PedidoAPI.Models.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
