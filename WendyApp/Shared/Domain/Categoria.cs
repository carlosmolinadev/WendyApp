using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }

        [JsonIgnore]
        public virtual List<InsumoCategoria> Insumos { get; set; }
    }
}
