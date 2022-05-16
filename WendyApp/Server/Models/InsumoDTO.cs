using Newtonsoft.Json;
using System;
using System.Collections.Generic;


#nullable disable

namespace WendyApp.Server.Models
{
    public class InsumoDTO
    {
        [JsonIgnore]
        public int InsumoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        [JsonIgnore]
        public virtual List<InsumoCategoriaDTO> Categorias { get; set; }
        [JsonIgnore]
        public virtual List<PedidoInsumoDTO> Pedidos { get; set; }
        [JsonIgnore]
        public virtual List<ProveedorInsumoDTO> Proveedores { get; set; }
    }

    public class ReturnInsumoDTO
    {
        public int InsumoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Cantidad { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }
    }
}
