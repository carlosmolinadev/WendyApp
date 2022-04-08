using System.ComponentModel.DataAnnotations.Schema;

namespace WendyApp.Server.Models
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Role { get; set; }

        [NotMapped]
        public string PasswordProporcionado { get; set; }

        public int SucursalId { get; set; }

        public virtual SucursalDTO Sucursal { get; set; }
    }
}
