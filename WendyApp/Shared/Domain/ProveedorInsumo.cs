using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class ProveedorInsumo
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId { get; set; }

        [ForeignKey(nameof(Insumo))]
        public int InsumoId { get; set; }
        public double Preciocompra { get; set; }

        public virtual Insumo Insumo { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
