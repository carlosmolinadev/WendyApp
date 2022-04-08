﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class InsumoCategoria
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Insumo))]
        public int InsumoId { get; set; }

        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Insumo Insumo { get; set; }
    }
}
