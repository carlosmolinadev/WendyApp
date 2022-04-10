using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Server.Models
{
    public class PedidoDTO
    {
        [JsonIgnore]
        public int PedidoId { get; set; }
        public double CostoTransporte { get; set; } = 0;
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int ProveedorId { get; set; }

        public int SucursalId { get; set; }

        public int EstadoPedidosId { get; set; }
        [JsonIgnore]
        public  ProveedorDTO Proveedor { get; set; }
        [JsonIgnore]
        public  SucursalDTO Sucursal { get; set; }
        [JsonIgnore]
        public EstadoPedidoDTO EstadoPedidos { get; set; }
        [JsonIgnore]
        public virtual List<HistorialPedidoDTO> HistorialPedidos { get; set; }
        [JsonIgnore]
        public virtual List<InsumoDTO> Insumos { get; set; }
    }
}
