using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class InsumoCategoriaDTO
    {

        public int InsumoId { get; set; }

        public int CategoriaId { get; set; }

        [JsonIgnore]
        public virtual CategoriaDTO Categoria { get; set; }
        [JsonIgnore]
        public virtual InsumoDTO Insumo { get; set; }
    }
}
