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
                    Estado = "Enviada"
                },
                new EstadoPedido
                {
                    EstadoPedidoId = 2,
                    Estado = "Aprobada"
                },
                new EstadoPedido
                {
                    EstadoPedidoId = 3,
                    Estado = "Despachada"
                },
                new EstadoPedido
                {
                    EstadoPedidoId = 4,
                    Estado = "Cancelada"
                },
                new EstadoPedido
                {
                    EstadoPedidoId = 5,
                    Estado = "Recibida"
                }
            );
        }
    }
}
