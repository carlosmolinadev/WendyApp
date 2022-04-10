using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class PaisDTO
    {
        [JsonIgnore]
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        [JsonIgnore]
        public virtual List<PaisProveedorDTO> PaisProveedor { get; set; }
        [JsonIgnore]
        public virtual List<SucursalDTO> Sucursales { get; set; }
    }
}
