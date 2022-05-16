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
                },
                new Pais
                {
                    PaisId = 4,
                    Nombre = "Brasil"
                },
                new Pais
                {
                    PaisId = 5,
                    Nombre = "México"
                },
                new Pais
                {
                    PaisId = 6,
                    Nombre = "Argentina"
                },
                new Pais
                {
                    PaisId = 7,
                    Nombre = "Venezuela"
                },
                new Pais
                {
                    PaisId = 8,
                    Nombre = "Puerto Rico"
                },
                new Pais
                {
                    PaisId = 9,
                    Nombre = "Chile"
                },
                new Pais
                {
                    PaisId = 10,
                    Nombre = "Colombia"
                },
                new Pais
                {
                    PaisId = 11,
                    Nombre = "Panamá"
                },
                new Pais
                {
                    PaisId = 12,
                    Nombre = "Uruguay"
                },
                new Pais
                {
                    PaisId = 13,
                    Nombre = "Ecuador"
                },
                new Pais
                {
                    PaisId = 14,
                    Nombre = "Perú"
                },
                new Pais
                {
                    PaisId = 15,
                    Nombre = "Paraguay"
                },
                new Pais
                {
                    PaisId = 16,
                    Nombre = "República Dominicana"
                },
                new Pais
                {
                    PaisId = 17,
                    Nombre = "Honduras"
                },
                new Pais
                {
                    PaisId = 18,
                    Nombre = "Nicaragua"
                },
                new Pais
                {
                    PaisId = 19,
                    Nombre = "España"
                },
                new Pais
                {
                    PaisId = 20,
                    Nombre = "Rusia"
                },
                new Pais
                {
                    PaisId = 21,
                    Nombre = "Austria"
                },
                new Pais
                {
                    PaisId = 22,
                    Nombre = "Suecia"
                },
                new Pais
                {
                    PaisId = 23,
                    Nombre = "Francia"
                },
                new Pais
                {
                    PaisId = 24,
                    Nombre = "Portugal"
                },
                new Pais
                {
                    PaisId = 25,
                    Nombre = "Reino Unido"
                },
                new Pais
                {
                    PaisId = 26,
                    Nombre = "Irlanda"
                },
                new Pais
                {
                    PaisId = 27,
                    Nombre = "Alemania"
                },
                new Pais
                {
                    PaisId = 28,
                    Nombre = "Italia"
                },
                new Pais
                {
                    PaisId = 29,
                    Nombre = "Grecia"
                },
                new Pais
                {
                    PaisId = 30,
                    Nombre = "Bélgica"
                }
            );
        }
    }
}
