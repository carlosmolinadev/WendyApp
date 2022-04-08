using System;
using System.Collections.Generic;

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

        public virtual List<CategoriaDTO> Categorias { get; set; }
        public virtual List<PedidoDTO> Pedidos { get; set; }
        public virtual List<ProveedorDTO> Proveedores { get; set; }
    }
}
