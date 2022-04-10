using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Server.Models
{
    public class HistorialPedidoDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int EstadoPedidosId { get; set; }
        [JsonIgnore]
        public virtual EstadoPedidoDTO EstadoPedidos { get; set; }
        [JsonIgnore]
        public virtual PedidoDTO Pedido { get; set; }
    }
}
