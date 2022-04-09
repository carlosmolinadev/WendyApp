﻿namespace WendyApp.Server.Models
{
    public class InsumoCategoriaDTO
    {
        public int Id { get; set; }

        public int InsumoId { get; set; }

        public int CategoriaId { get; set; }

        public virtual CategoriaDTO Categoria { get; set; }
        public virtual InsumoDTO Insumo { get; set; }
    }
}