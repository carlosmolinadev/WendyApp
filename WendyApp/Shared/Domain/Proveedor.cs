using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Proveedor
    {

        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual List<PaisProveedor> PaisProveedor{ get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
        public virtual List<ProveedorInsumo> ProveedorInsumos { get; set; }
    }
}
