using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WendyApp.Server.Models
{
    public class PaisDTO
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        //public virtual List<PaisProveedor> PaisProveedor { get; set; }
        public virtual List<SucursalDTO> Sucursales { get; set; }
    }
}
