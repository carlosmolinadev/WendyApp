using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Server.Models
{
    public class HistorialPedidoDTO
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }
        [ForeignKey(nameof(EstadoPedidoDTO))]
        public int EstadoPedidosId { get; set; }

        public virtual EstadoPedidoDTO EstadoPedidos { get; set; }
        public virtual PedidoDTO Pedido { get; set; }
    }
}
