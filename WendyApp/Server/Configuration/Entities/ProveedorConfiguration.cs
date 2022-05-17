using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasData(
                                new Proveedor
                                {
                                    ProveedorId = 1,
                                    Nombre = "Super selectos",
                                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                                },
                new Proveedor
                {
                    ProveedorId = 2,
                    Nombre = "La despensa de don juan",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 3,
                    Nombre = "Supermercado Saretto",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 4,
                    Nombre = "Supermercado Express",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 5,
                    Nombre = "Walmart",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 6,
                    Nombre = "Carrefour",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 7,
                    Nombre = "Supermercado y Frutería California",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 8,
                    Nombre = "Supermax",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 9,
                    Nombre = "Jumbo",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 10,
                    Nombre = "Supermercado El Sol S A S",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 11,
                    Nombre = "Super 99",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 12,
                    Nombre = "Supermercado Pingüino",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 13,
                    Nombre = "Corporación Favorita",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 14,
                    Nombre = "Supermercado La Torre Centro Histórico",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 15,
                    Nombre = "Supermercado Plaza Vea",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 16,
                    Nombre = "Supermercados Nacional",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 17,
                    Nombre = "Supermercado Paiz",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 18,
                    Nombre = "Supermercado La Unión",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 19,
                    Nombre = "Supermercados Día",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 20,
                    Nombre = "Supermercado Auchan",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 21,
                    Nombre = "Supermercado Hofer",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 22,
                    Nombre = "Ica Supermarket",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 23,
                    Nombre = "Supermercado Leclerc",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 24,
                    Nombre = "Corporación Froiz",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 25,
                    Nombre = "Supermercado Tesco",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 26,
                    Nombre = "Supermercado Spr",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 27,
                    Nombre = "Supermercados Aldi",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 28,
                    Nombre = "Supermercado Esselung",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 29,
                    Nombre = "Supermercado Msoutis",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 30,
                    Nombre = "Supermercado Amarás el Colruyt",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                }
            );
        }
    }
}
