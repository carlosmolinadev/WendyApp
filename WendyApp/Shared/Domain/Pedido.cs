using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [ForeignKey(nameof(Sucursal))]
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }

        [ForeignKey(nameof(EstadoPedido))]
        public int EstadoPedidosId { get; set; }
        public EstadoPedido EstadoPedidos { get; set; }

        [JsonIgnore]
        public virtual List<HistorialPedido> HistorialPedidos { get; set; }
        [JsonIgnore]
        public virtual List<PedidoInsumo> Insumos { get; set; }
    }
}
