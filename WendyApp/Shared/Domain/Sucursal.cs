using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Direccion { get; set; }

        [ForeignKey(nameof(Pais))]
        public int PaisId { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}
