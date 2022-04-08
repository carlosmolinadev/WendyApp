using System;
using System.Collections.Generic;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }

        public virtual List<InsumoCategoria> InsumoCategoria { get; set; }
    }
}
