using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {

        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasData(
                new Categoria
                {
                    CategoriaId = 1,
                    Nombre = "Vegetales"
                },
                new Categoria
                {
                    CategoriaId = 2,
                    Nombre = "Carnes"
                }
            );
        }
    }
}
