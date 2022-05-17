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
                },
                new Usuario
                {
                    UsuarioId = 3,
                    Nickname = "erisaravia",
                    Password = generatedPassword.Password,
                    PasswordSalt = generatedPassword.PasswordSalt,
                    Email = "sa18004@ues.edu.sv",
                    Rol = "SUPERVISOR",
                    SucursalId = 4
                },
                new Usuario
                {
                    UsuarioId = 4,
                    Nickname = "eligarcia",
                    Password = generatedPassword.Password,
                    PasswordSalt = generatedPassword.PasswordSalt,
                    Email = "gh06007@ues.edu.sv",
                    Rol = "SUPERVISOR",
                    SucursalId = 46
                },
                new Usuario
                {
                    UsuarioId = 5,
                    Nickname = "efrgomez",
                    Password = generatedPassword.Password,
                    PasswordSalt = generatedPassword.PasswordSalt,
                    Email = "gf18005@ues.edu.sv",
                    Rol = "SUPERVISOR",
                    SucursalId = 55
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
