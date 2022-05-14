using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                   ProveedorId= 1,
                   Nombre = "Super selectos",
                   Descripcion = "Distribuidor de carnes y pan"
                }
            );
        }
    }
}
