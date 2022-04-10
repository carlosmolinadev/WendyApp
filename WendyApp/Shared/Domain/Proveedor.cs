using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Proveedor
    {

        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        [JsonIgnore]
        public virtual List<PaisProveedor> Paises { get; set; }
        [JsonIgnore]
        public virtual List<Pedido> Pedidos { get; set; }
        [JsonIgnore]
        public virtual List<ProveedorInsumo> Insumos { get; set; }
    }
}
