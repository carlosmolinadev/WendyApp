using System.Collections.Generic;

namespace WendyApp.Server.Models
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public virtual List<InsumoCategoriaDTO> Insumos { get; set; }
    }
}
