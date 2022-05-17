using WendyApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WendyApp.Server.Configuration.Entities
{
    public class PaisProveedorConfiguration : IEntityTypeConfiguration<PaisProveedor>
    {
        public void Configure(EntityTypeBuilder<PaisProveedor> builder)
        {
            builder.HasData(
                new PaisProveedor
                {
                    Id = 1,
                    CostoTransporte = 2.0m,
                    PaisId = 1,
                    ProveedorId = 1
                },
                new PaisProveedor
                {
                    Id = 2,
                    CostoTransporte = 2.2m,
                    PaisId = 1,
                    ProveedorId = 2
                },
                new PaisProveedor
                {
                    Id = 3,
                    CostoTransporte = 3.0m,
                    PaisId = 2,
                    ProveedorId = 3
                },
                new PaisProveedor
                {
                    Id = 4,
                    CostoTransporte = 2.5m,
                    PaisId = 2,
                    ProveedorId = 4
                },
                new PaisProveedor
                {
                    Id = 5,
                    CostoTransporte = 3.5m,
                    PaisId = 1,
                    ProveedorId = 5
                },
                new PaisProveedor
                {
                    Id = 6,
                    CostoTransporte = 4.0m,
                    PaisId = 2,
                    ProveedorId = 2
                },
                new PaisProveedor
                {
                    Id = 7,
                    CostoTransporte = 4.0m,
                    PaisId = 1,
                    ProveedorId = 7
                },
                new PaisProveedor
                {
                    Id = 8,
                    CostoTransporte = 2.0m,
                    PaisId = 2,
                    ProveedorId = 8
                },
                new PaisProveedor
                {
                    Id = 9,
                    CostoTransporte = 3.0m,
                    PaisId = 2,
                    ProveedorId = 9
                },
                new PaisProveedor
                {
                    Id = 10,
                    CostoTransporte = 4.0m,
                    PaisId = 1,
                    ProveedorId = 10
                },
                new PaisProveedor
                {
                    Id = 11,
                    CostoTransporte = 4.5m,
                    PaisId = 2,
                    ProveedorId = 11
                },
                new PaisProveedor
                {
                    Id = 12,
                    CostoTransporte = 4.0m,
                    PaisId = 2,
                    ProveedorId = 12
                },
                new PaisProveedor
                {
                    Id = 13,
                    CostoTransporte = 3.5m,
                    PaisId = 1,
                    ProveedorId = 13
                },
                new PaisProveedor
                {
                    Id = 14,
                    CostoTransporte = 2.5m,
                    PaisId = 1,
                    ProveedorId = 15
                },
                new PaisProveedor
                {
                    Id = 15,
                    CostoTransporte = 2.0m,
                    PaisId = 2,
                    ProveedorId = 14
                },
                new PaisProveedor
                {
                    Id = 16,
                    CostoTransporte = 6.0m,
                    PaisId = 19,
                    ProveedorId = 16
                },
                new PaisProveedor
                {
                    Id = 17,
                    CostoTransporte = 3.0m,
                    PaisId = 1,
                    ProveedorId = 17
                },
                new PaisProveedor
                {
                    Id = 18,
                    CostoTransporte = 2.5m,
                    PaisId = 2,
                    ProveedorId = 18
                },
                new PaisProveedor
                {
                    Id = 19,
                    CostoTransporte = 5.0m,
                    PaisId = 23,
                    ProveedorId = 19
                },
                new PaisProveedor
                {
                    Id = 20,
                    CostoTransporte = 6.0m,
                    PaisId = 19,
                    ProveedorId = 20
                },
                new PaisProveedor
                {
                    Id = 21,
                    CostoTransporte = 5.5m,
                    PaisId = 23,
                    ProveedorId = 21
                },
                new PaisProveedor
                {
                    Id = 22,
                    CostoTransporte = 8.0m,
                    PaisId = 19,
                    ProveedorId = 22
                },
                new PaisProveedor
                {
                    Id = 23,
                    CostoTransporte = 7.5m,
                    PaisId = 19,
                    ProveedorId = 23
                },
                new PaisProveedor
                {
                    Id = 24,
                    CostoTransporte = 7.0m,
                    PaisId = 23,
                    ProveedorId = 24
                },
                new PaisProveedor
                {
                    Id = 25,
                    CostoTransporte = 6.5m,
                    PaisId = 23,
                    ProveedorId = 25
                },
                new PaisProveedor
                {
                    Id = 26,
                    CostoTransporte = 7.5m,
                    PaisId = 19,
                    ProveedorId = 26
                },
                new PaisProveedor
                {
                    Id = 27,
                    CostoTransporte = 8.0m,
                    PaisId = 19,
                    ProveedorId = 27
                },
                new PaisProveedor
                {
                    Id = 28,
                    CostoTransporte = 6.5m,
                    PaisId = 23,
                    ProveedorId = 28
                },
                new PaisProveedor
                {
                    Id = 29,
                    CostoTransporte = 9.0m,
                    PaisId = 19,
                    ProveedorId = 29
                },
                new PaisProveedor
                {
                    Id = 30,
                    CostoTransporte = 6.0m,
                    PaisId = 23,
                    ProveedorId = 30
                }
            );
        }
    }
}
