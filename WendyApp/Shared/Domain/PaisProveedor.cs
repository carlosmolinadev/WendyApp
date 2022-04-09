using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    [Table("PaisesProveedores")]
    public class PaisProveedor
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Pais))]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }


    }
}