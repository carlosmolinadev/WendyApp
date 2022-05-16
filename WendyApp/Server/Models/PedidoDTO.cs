using Newtonsoft.Json;
using System;
using System.Collections.Generic;


#nullable disable

namespace WendyApp.Server.Models
{
    public class PedidoDTO
    {
        [JsonIgnore]
        public int PedidoId { get; set; }

        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int ProveedorId { get; set; }

        public int SucursalId { get; set; }

        public int EstadoPedidoId { get; set; }
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

    public class CreatePedidoDTO
    {
        [JsonIgnore]
        public int PedidoId { get; set; }

        public int ProveedorId { get; set; }

        public int SucursalId { get; set; }

        public virtual List<PedidoInsumoDTO> Insumos { get; set; }

        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }

    public class ReturnPedidoDTO : ReturnBasicPedidoDetailDTO
    {
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<ReturnEstadoPedidoDTO> Historial { get; set; }
        public decimal CostoPedido  { get; set; }
        public decimal Total { get; set; }
    }

    public class ReturnBasicPedidoDetailDTO
    {
        public int PedidoId { get; set; }

        public ReturnProveedorDTO Proveedor { get; set; }

        public ReturnSucursalDTO Sucursal { get; set; }
        public ReturnEstadoPedidoDTO Estado { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<ReturnInsumoDTO> Insumo { get; set; }

    }
}
