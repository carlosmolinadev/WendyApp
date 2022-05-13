namespace WendyApp.Server.Models
{
    public class PedidoInsumoDTO
    {
        public int InsumoId { get; set; }
        public virtual InsumoDTO Insumo { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public int PedidoId { get; set; }
        public virtual PedidoDTO Pedido { get; set; }
    }
}
