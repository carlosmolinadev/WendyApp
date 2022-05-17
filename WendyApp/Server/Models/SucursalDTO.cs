using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class SucursalDTO 
    {
        [JsonIgnore]
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

    public class ReturnSucursalDTO
    {
        public int SucursalId { get; set; }

        public string Nombre { get; set; }
    }

    public class JsonSucursal
    {
        public int sucursalId { get; set; }
        public string nombre { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string direccion { get; set; }
        public int paisId { get; set; }
        public string pais { get; set; }
    }
}
