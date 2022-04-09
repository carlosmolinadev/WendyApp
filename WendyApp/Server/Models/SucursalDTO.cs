using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class SucursalDTO 
    {
        public int SucursalId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public int PaisId { get; set; }

        [JsonIgnore]
        public virtual PaisDTO pais { get; set; }
    }
}
