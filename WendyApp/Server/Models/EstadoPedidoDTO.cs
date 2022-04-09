using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Server.Models
{
    public class EstadoPedidoDTO
    {
        public int EstadoPedidoId { get; set; }
        public string Estado { get; set; }

        public virtual List<HistorialPedidoDTO> HistorialPedidos { get; set; }
        public virtual List<PedidoDTO> Pedidos { get; set; }
    }
}
