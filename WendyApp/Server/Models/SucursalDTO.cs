using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WendyApp.Server.Models
{
    public class SucursalDTO 
    {
        public int SucursalId { get; set; }

        [Required]
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public int PaisId { get; set; }

        public virtual PaisDTO pais { get; set; }
        //public virtual List<Pedido> Pedidos { get; set; }
        //public virtual List<Usuario> Usuarios { get; set; }
    }
}
