using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WendyApp.Shared.Domain;
using System.Security.Cryptography;
using System.Text;

namespace WendyApp.Server.Configuration.Entities
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        private GeneratedPassword CreatePassword(string password)
        {
            using var hmac = new HMACSHA512();

            var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            var key = hmac.Key;

            var generatedPassword = new GeneratedPassword { Password = hashedPassword, PasswordSalt = key };

            return generatedPassword;
        }

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            var generatedPassword = CreatePassword("Password1#");

            builder.HasData(
                new Usuario
                {
                    UsuarioId = 1,
                    Nickname = "admin",
                    Password = generatedPassword.Password,
                    PasswordSalt = generatedPassword.PasswordSalt,
                    Email = "usuario_admin@wendy.com",
                    Rol = "ADMIN",
                    SucursalId = 1
                },
                new Usuario
                {
                    UsuarioId = 2,
                    Nickname = "carmolina",
                    Password = generatedPassword.Password,
                    PasswordSalt = generatedPassword.PasswordSalt,
                    Email = "carlos_molina@wendy.com",
                    Rol = "SUPERVISOR",
                    SucursalId = 1
                }
            );
        }
    }
    public class GeneratedPassword
    {
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
