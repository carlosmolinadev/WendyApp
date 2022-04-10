using WendyApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WendyApp.Server.Configuration.Entities
{
    public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder.HasData(
                new Sucursal
                {
                    SucursalId = 1,
                    Nombre = "Sucursal Metrocentro",
                    Direccion = "Metrocentro 8va etapa",
                    FechaCreacion = System.DateTime.Now,
                    PaisId = 1
                }
            );
        }
    }
}
