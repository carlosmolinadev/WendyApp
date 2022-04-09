﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Wendy.Server.Data;

namespace WendyApp.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WendyApp.Shared.Domain.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.EstadoPedido", b =>
                {
                    b.Property<int>("EstadoPedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EstadoPedidoId");

                    b.ToTable("EstadoPedidos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.HistorialPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("EstadoPedidosId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoPedidosId");

                    b.HasIndex("PedidoId");

                    b.ToTable("HistorialPedidos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Insumo", b =>
                {
                    b.Property<int>("InsumoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("InsumoId");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.InsumoCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("InsumoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("InsumoId");

                    b.ToTable("InsumoCategoria");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("PaisId");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.PaisProveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaisId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("PaisProveedor");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CostoTransporte")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("EstadoPedidosId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PedidoId");

                    b.HasIndex("EstadoPedidosId");

                    b.HasIndex("ProveedorId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.PedidoInsumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InsumoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoInsumo");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Proveedor", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.ProveedorInsumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InsumoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double>("Preciocompra")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("ProveedorInsumo");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PaisId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("SucursalId");

                    b.HasIndex("PaisId");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nickname")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("RAW(2000)");

                    b.Property<string>("Role")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.HistorialPedido", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.EstadoPedido", "EstadoPedidos")
                        .WithMany("HistorialPedidos")
                        .HasForeignKey("EstadoPedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Pedido", "Pedido")
                        .WithMany("HistorialPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoPedidos");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.InsumoCategoria", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Categoria", "Categoria")
                        .WithMany("Insumos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Insumo", "Insumo")
                        .WithMany("Categorias")
                        .HasForeignKey("InsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Insumo");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.PaisProveedor", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Pais", "Pais")
                        .WithMany("Proveedores")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Proveedor", "Proveedor")
                        .WithMany("Paises")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Pedido", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.EstadoPedido", "EstadoPedidos")
                        .WithMany("Pedidos")
                        .HasForeignKey("EstadoPedidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Proveedor", "Proveedor")
                        .WithMany("Pedidos")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Sucursal", "Sucursal")
                        .WithMany("Pedidos")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoPedidos");

                    b.Navigation("Proveedor");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.PedidoInsumo", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Insumo", "Insumo")
                        .WithMany("Pedidos")
                        .HasForeignKey("InsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Pedido", "Pedido")
                        .WithMany("Insumos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.ProveedorInsumo", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Insumo", "Insumo")
                        .WithMany("Proveedores")
                        .HasForeignKey("InsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WendyApp.Shared.Domain.Proveedor", "Proveedor")
                        .WithMany("Insumos")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Sucursal", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Pais", "Pais")
                        .WithMany("Sucursales")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Usuario", b =>
                {
                    b.HasOne("WendyApp.Shared.Domain.Sucursal", "Sucursal")
                        .WithMany("Usuarios")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Categoria", b =>
                {
                    b.Navigation("Insumos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.EstadoPedido", b =>
                {
                    b.Navigation("HistorialPedidos");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Insumo", b =>
                {
                    b.Navigation("Categorias");

                    b.Navigation("Pedidos");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Pais", b =>
                {
                    b.Navigation("Proveedores");

                    b.Navigation("Sucursales");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Pedido", b =>
                {
                    b.Navigation("HistorialPedidos");

                    b.Navigation("Insumos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Proveedor", b =>
                {
                    b.Navigation("Insumos");

                    b.Navigation("Paises");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("WendyApp.Shared.Domain.Sucursal", b =>
                {
                    b.Navigation("Pedidos");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
