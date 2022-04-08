using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WendyApp.Shared.Domain
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Role { get; set; }

        [ForeignKey(nameof(Sucursal))]
        public int SucursalId { get; set; }

        public virtual Sucursal Sucursal { get; set; }
    }
}
