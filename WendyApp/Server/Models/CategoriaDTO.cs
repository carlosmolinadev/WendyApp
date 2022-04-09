using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        [JsonIgnore]
        public virtual List<InsumoDTO> Insumos { get; set; }
    }
}
