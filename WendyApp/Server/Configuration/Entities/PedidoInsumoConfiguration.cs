using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class PedidoInsumoConfiguration : IEntityTypeConfiguration<PedidoInsumo>
    {
        public void Configure(EntityTypeBuilder<PedidoInsumo> builder)
        {
            builder.HasData(
                new PedidoInsumo
                {
                   
                }
            );
        }
    }
}
