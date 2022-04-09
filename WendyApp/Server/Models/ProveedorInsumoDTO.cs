namespace WendyApp.Server.Models
{
    public class ProveedorInsumoDTO
    {
        public int ProveedorId { get; set; }
        public virtual ProveedorDTO Proveedor { get; set; }

        public int InsumoId { get; set; }
        public virtual InsumoDTO Insumo { get; set; }

        public double Preciocompra { get; set; }
    }
}
