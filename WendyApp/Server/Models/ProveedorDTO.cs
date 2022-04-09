using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Server.Models
{
    public class ProveedorDTO
    {

        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual List<PaisDTO> Paises { get; set; }
        public virtual List<PedidoDTO> Pedidos { get; set; }
        public virtual List<InsumoDTO> Insumos { get; set; }
    }
}
