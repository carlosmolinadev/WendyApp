using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Server.Models
{
    public class InsumoDTO
    {
        public int InsumoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }

        [JsonIgnore]
        public virtual List<CategoriaDTO> Categorias { get; set; }
        [JsonIgnore]
        public virtual List<PedidoDTO> Pedidos { get; set; }
        [JsonIgnore]
        public virtual List<ProveedorDTO> Proveedores { get; set; }
    }
}
