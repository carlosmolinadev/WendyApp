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
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {

        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.HasData(
                new Insumo
                {
                }
            );
        }
    }
}
