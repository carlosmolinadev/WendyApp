using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Server.Models
{
    public class ProveedorDTO
    {
        [JsonIgnore]
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        [JsonIgnore]
        public virtual List<PaisDTO> Paises { get; set; }
        [JsonIgnore]
        public virtual List<PedidoDTO> Pedidos { get; set; }
        [JsonIgnore]
        public virtual List<InsumoDTO> Insumos { get; set; }
    }
}
