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
                }
            );
        }
    }
}
