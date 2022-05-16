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
                },
                new Categoria
                {
                    CategoriaId = 3,
                    Nombre = "Pan"
                },
                new Categoria
                {
                    CategoriaId = 4,
                    Nombre = "Lacteos"
                },
                new Categoria
                {
                    CategoriaId = 5,
                    Nombre = "Especias y condimentos"
                },
                new Categoria
                {
                    CategoriaId = 6,
                    Nombre = "Bebidas"
                },
                new Categoria
                {
                    CategoriaId = 7,
                    Nombre = "Electrodomésticos"
                },
                new Categoria
                {
                    CategoriaId = 8,
                    Nombre = "Servicios básicos"
                },
                new Categoria
                {
                    CategoriaId = 9,
                    Nombre = "Papel"
                },
                new Categoria
                {
                    CategoriaId = 10,
                    Nombre = "Cajas y Bolsas"
                },
                new Categoria
                {
                    CategoriaId = 11,
                    Nombre = "Mobiliario"
                },
                new Categoria
                {
                    CategoriaId = 12,
                    Nombre = "Vajilla y similares"
                },
                new Categoria
                {
                    CategoriaId = 13,
                    Nombre = "Artículos de Limpueza"
                },
                new Categoria
                {
                    CategoriaId = 14,
                    Nombre = "Otros"
                }
            );
        }
    }
}
