using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class InsumoCategoriaConfiguration : IEntityTypeConfiguration<InsumoCategoria>
    {

        public void Configure(EntityTypeBuilder<InsumoCategoria> builder)
        {
            builder.HasData(
                new InsumoCategoria
                {
                    Id = 1,
                    InsumoId = 1,
                    CategoriaId = 1
                }
            );
        }
    }
}
