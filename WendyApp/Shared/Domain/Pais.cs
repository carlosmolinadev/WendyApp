using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WendyApp.Shared.Domain
{
    public class Pais
    {

        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public virtual List<PaisProveedor> PaisProveedor{ get; set; }
        public virtual List<Sucursal> Sucursales { get; set; }
    }
}
