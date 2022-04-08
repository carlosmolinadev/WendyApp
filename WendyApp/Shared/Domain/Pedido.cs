using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public double CostoTransporte { get; set; } = 0;
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId { get; set; }

        [ForeignKey(nameof(Sucursal))]
        public int SucursalId { get; set; }

        [ForeignKey(nameof(EstadoPedido))]
        public int EstadoPedidosId { get; set; }

        public  Proveedor Proveedor { get; set; }
        public  Sucursal Sucursal { get; set; }
        public EstadoPedido EstadoPedidos { get; set; }
        public virtual List<HistorialPedido> HistorialPedidos { get; set; }
        public virtual List<PedidoInsumo> PedidoInsumos { get; set; }
    }
}
