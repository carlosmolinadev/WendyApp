using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Server.Models
{
    public class EstadoPedidoDTO
    {
        [JsonIgnore]
        public int EstadoPedidoId { get; set; }
        public string Estado { get; set; }
        [JsonIgnore]
        public virtual List<HistorialPedidoDTO> HistorialPedidos { get; set; }
        [JsonIgnore]
        public virtual List<PedidoDTO> Pedidos { get; set; }
    }
}
