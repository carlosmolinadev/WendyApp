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
                    FechaCreacion = DateTime.Now
                }
            );
        }
    }
}
