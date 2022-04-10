using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class PaisProveedorDTO
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int PaisId { get; set; }
  
        public virtual PaisDTO Pais { get; set; }

        public int ProveedorId { get; set; }

        public virtual ProveedorDTO Proveedor { get; set; }
    }
}
