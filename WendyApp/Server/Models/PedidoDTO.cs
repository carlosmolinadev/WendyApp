using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Server.Models
{
    public class PedidoDTO
    {
        public int PedidoId { get; set; }
        public double CostoTransporte { get; set; } = 0;
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId { get; set; }

        [ForeignKey(nameof(Sucursal))]
        public int SucursalId { get; set; }

        [ForeignKey(nameof(EstadoPedidoDTO))]
        public int EstadoPedidosId { get; set; }

        public  ProveedorDTO Proveedor { get; set; }
        public  SucursalDTO Sucursal { get; set; }
        public EstadoPedidoDTO EstadoPedidos { get; set; }
        public virtual List<HistorialPedidoDTO> HistorialPedidos { get; set; }
        public virtual List<InsumoDTO> Insumos { get; set; }
    }
}
