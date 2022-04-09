using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class PedidoInsumo
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Insumo))]
        public int InsumoId { get; set; }
        public virtual Insumo Insumo { get; set; }       

        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

    }
}