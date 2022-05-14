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
                }
            );
        }
    }
}
