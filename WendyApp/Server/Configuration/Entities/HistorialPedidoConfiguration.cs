using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class HistorialPedidoConfiguration : IEntityTypeConfiguration<HistorialPedido>
    {

        public void Configure(EntityTypeBuilder<HistorialPedido> builder)
        {

            builder.HasData(
                new HistorialPedido
                {
                }
            );
        }
    }
}
