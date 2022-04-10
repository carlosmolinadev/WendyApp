using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WendyApp.Server.Models
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        [Required]
        public string Rol { get; set; }

        [NotMapped]
        public string PasswordProporcionado { get; set; }
        public int SucursalId { get; set; }
        [JsonIgnore]
        public virtual SucursalDTO Sucursal { get; set; }
    }

    public class UsuarioDisplayDTO
    {
        public int UsuarioId { get; set; }
     
        public string Nickname { get; set; }


        public string Email { get; set; }
        
        public string Rol { get; set; }

        public int SucursalId { get; set; }
        
        public virtual SucursalDTO Sucursal { get; set; }
    }

    public class UsuarioCredentialsDTO
    {
        public string Nickname { get; set; }
        public string Token { get; set; }
    }
}
