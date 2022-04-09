using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class HistorialPedido
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
       
        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }

        [ForeignKey(nameof(EstadoPedido))]
        public int EstadoPedidosId { get; set; }

        public virtual EstadoPedido EstadoPedidos { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
