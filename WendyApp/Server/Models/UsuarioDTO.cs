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
        [Required]
        public string Rol { get; set; }

        [NotMapped]
        public string PasswordProporcionado { get; set; }
        public int SucursalId { get; set; }
        [JsonIgnore]
        public virtual SucursalDTO Sucursal { get; set; }
    }
}
