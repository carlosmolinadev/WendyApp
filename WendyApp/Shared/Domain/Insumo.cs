using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Insumo
    {
        public int InsumoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual List<InsumoCategoria> InsumoCategoria { get; set; }
        public virtual List<PedidoInsumo> PedidoInsumos { get; set; }
        public virtual List<ProveedorInsumo> ProveedorInsumos { get; set; }
    }
}
