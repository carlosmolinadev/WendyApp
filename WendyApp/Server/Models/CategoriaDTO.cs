using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class CategoriaDTO
    {
        [JsonIgnore]
        public int CategoriaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [JsonIgnore]
        public List<InsumoDTO> Insumos { get; set; }
    }
}
