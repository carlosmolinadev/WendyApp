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
                    Nombre = "Super selectos - El Salvador",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 2,
                    Nombre = "Supermercado La Torre Centro Histórico - Guatemala",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 3,
                    Nombre = "Supermercado Saretto - Costa Rica",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 4,
                    Nombre = "Supermercado Brasil - Brasil",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 5,
                    Nombre = "Walmart Express - México",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 6,
                    Nombre = "Carrefour - Argentina",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 7,
                    Nombre = "Supermercado y Frutería California - Venezuela",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 8,
                    Nombre = "Supermax - Puerto Rico",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 9,
                    Nombre = "Jumbo - Chile",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 10,
                    Nombre = "Supermercado El Soll S A S - Colombia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 11,
                    Nombre = "Super 99 - Panamá",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 12,
                    Nombre = "Supermercado Pingüino - Uruguay",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 13,
                    Nombre = "Corporación Favorita - Ecuador",
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
                    Nombre = "Supermercado Plaza Vea - Perú",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 16,
                    Nombre = "Supermercados Nacional - República Dominicana",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 17,
                    Nombre = "Supermercado Paiz - Honduras",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 18,
                    Nombre = "Supermercado La Unión - Nicaragua",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 19,
                    Nombre = "Supermercados Día - España",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 20,
                    Nombre = "Supermercado Auchan - Rusia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 21,
                    Nombre = "Supermercado Hofer - Austria",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 22,
                    Nombre = "Ica Supermarket - Suecia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 23,
                    Nombre = "Supermercado Leclerc - Francia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 24,
                    Nombre = "Corporación Froiz - Portugal",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 25,
                    Nombre = "Supermercado Tesco - Reino Unido",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 26,
                    Nombre = "Supermercado Spr - Irlanda",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 27,
                    Nombre = "Supermercados Aldi - Alemania",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 28,
                    Nombre = "Supermercado Esselung - Italia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 29,
                    Nombre = "Supermercado Msoutis - Grecia",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                },
                new Proveedor
                {
                    ProveedorId = 30,
                    Nombre = "Supermercado Amarás el Colruyt - Bélgica",
                    Descripcion = "Distribuidor de carnes, pan y vegetales"
                }
            );
        }
    }
}
