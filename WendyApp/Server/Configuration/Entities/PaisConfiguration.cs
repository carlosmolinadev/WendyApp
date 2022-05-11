using WendyApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WendyApp.Server.Configuration.Entities
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.HasData(
                new Pais
                {
                    PaisId = 1,
                    Nombre = "El Salvador"
                },
                new Pais
                {
                    PaisId = 2,
                    Nombre = "Guatemala"
                },
                new Pais
                {
                    PaisId = 3,
                    Nombre = "Costa Rica"
                }
            );
        }
    }
}
