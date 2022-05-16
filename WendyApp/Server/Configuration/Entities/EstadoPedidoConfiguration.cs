using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;


namespace WendyApp.Server.Configuration.Entities
{
    public class EstadoPedidoConfiguration : IEntityTypeConfiguration<EstadoPedido>
    {

        public void Configure(EntityTypeBuilder<EstadoPedido> builder)
        {

            builder.HasData(
                new EstadoPedido
                {
                    EstadoPedidoId = 1,
                    Estado = "Pendiente"
                },
                new EstadoPedido
                {
                    EstadoPedidoId = 2,
                    Estado = "Orden Generada"
                }
            );
        }
    }
}
