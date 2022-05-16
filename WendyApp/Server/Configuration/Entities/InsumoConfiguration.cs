using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {

        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.HasData(
                new Insumo
                {
                    InsumoId = 1,
                    Nombre = "Tomate",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now,
                },
                new Insumo
                {
                    InsumoId = 2,
                    Nombre = "Lechuga",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 3,
                    Nombre = "Cebolla",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 4,
                    Nombre = "Pepinillo",
                    Descripcion = "Precio por frasco",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 5,
                    Nombre = "Papas",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 6,
                    Nombre = "Carne de Res",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 7,
                    Nombre = "Carne de Pollo",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 8,
                    Nombre = "Tocino",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 9,
                    Nombre = "Pan con ajonjolí",
                    Descripcion = "Precio por bolsa",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 10,
                    Nombre = "Queso",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 11,
                    Nombre = "Leche",
                    Descripcion = "Precio por litro",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 12,
                    Nombre = "Salsa de Tomate",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 13,
                    Nombre = "Mostaza",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 14,
                    Nombre = "Salsa Sandwich Spread",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 15,
                    Nombre = "Sal",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 16,
                    Nombre = "Pimienta",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 17,
                    Nombre = "Agua",
                    Descripcion = "Precio por botella",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 18,
                    Nombre = "Café",
                    Descripcion = "Precio por libra",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 19,
                    Nombre = "Soda",
                    Descripcion = "Precio por litro",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 20,
                    Nombre = "Cocina",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 21,
                    Nombre = "Freidora",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 22,
                    Nombre = "Cuarto frío",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 23,
                    Nombre = "Utensilios de cocina",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 24,
                    Nombre = "Agua",
                    Descripcion = "Precio por metro cúbico",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 25,
                    Nombre = "Electricidad",
                    Descripcion = "Precio por Kw/hora",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 26,
                    Nombre = "Internet",
                    Descripcion = "Precio por megas",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 27,
                    Nombre = "Servilletas",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 28,
                    Nombre = "Papel higiénico",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 29,
                    Nombre = "Toallas del hogar",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 30,
                    Nombre = "Empaques desechables",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 31,
                    Nombre = "Bolsas para llevar",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 32,
                    Nombre = "Mesas",
                    Descripcion = "Precio por Unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 33,
                    Nombre = "Sillas",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 34,
                    Nombre = "Lámparas - iluminación",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 35,
                    Nombre = "Platos",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 36,
                    Nombre = "Vasos",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 37,
                    Nombre = "Cucharas",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 38,
                    Nombre = "Tenedores",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 39,
                    Nombre = "Cuchillos",
                    Descripcion = "Precio por paquete",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 40,
                    Nombre = "Escobas",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 41,
                    Nombre = "Trapeadores",
                    Descripcion = "Precio por unidad",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 42,
                    Nombre = "Detergentes y desinfectantes",
                    Descripcion = "Precio por galón",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 43,
                    Nombre = "Alcohol gel",
                    Descripcion = "Precio por galón",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 44,
                    Nombre = "Jabbón para manos",
                    Descripcion = "Precio por galón",
                    FechaCreacion = DateTime.Now
                },
                new Insumo
                {
                    InsumoId = 45,
                    Nombre = "Otros",
                    Descripcion = "Precio por tipo de insumo",
                    FechaCreacion = DateTime.Now
                }
            );
        }
    }
}
