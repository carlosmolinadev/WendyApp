using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Server.Interfaces.IServices;
using WendyApp.Server.Services;
using WendyApp.Shared.Domain;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

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
                }
            );
        }
    }
}
