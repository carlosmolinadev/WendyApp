
using System.ComponentModel.DataAnnotations;


namespace WendyApp.Server.Models
{
    public class CredentialDTO
    {
        [Required]
        public string NickName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
