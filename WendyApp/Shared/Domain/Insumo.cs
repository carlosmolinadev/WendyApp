using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Insumo
    {
        public int InsumoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        [JsonIgnore]
        public virtual List<InsumoCategoria> Categorias { get; set; }
        [JsonIgnore]
        public virtual List<PedidoInsumo> Pedidos { get; set; }
        [JsonIgnore]
        public virtual List<ProveedorInsumo> Proveedores { get; set; }
    }
}
