using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class EstadoPedido
    {
        public int EstadoPedidoId { get; set; }
        public string Estado { get; set; }

        public virtual List<HistorialPedido> HistorialPedidos { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
    }
}
