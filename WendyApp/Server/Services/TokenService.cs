using IdentityServer4;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WendyApp.Server.Interfaces.IServices;
using WendyApp.Server.Models;

namespace WendyApp.Server.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));
        }
        public string CreateToken(UsuarioDTO usuarioDTO, SucursalDTO sucursalDTO)
        {
            
            var sucursal = new Sucursal { 
                                            sucursalId = sucursalDTO.SucursalId, 
                                            nombre = sucursalDTO.Nombre,
                                            direccion = sucursalDTO.Direccion, 
                                            fechaCreacion = sucursalDTO.FechaCreacion,
                                            paisId = sucursalDTO.pais.PaisId,
                                            pais = sucursalDTO.pais.Nombre,
            };

            var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512);
            var signingCredentials = credentials;

            //var nbf = DateTime.UtcNow.AddSeconds(-1);
            //var exp = DateTime.UtcNow.AddSeconds(86400);
            var payload = new JwtPayload(null, "", new List<Claim>(), null, null);

            payload.Add("usuarioId", usuarioDTO.UsuarioId);
            payload.Add("nickName", usuarioDTO.Nickname);
            payload.Add("rol", usuarioDTO.Rol);
            payload.Add("email", usuarioDTO.Email);
            payload.Add("sucursal", sucursal);

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = new JwtSecurityToken(new JwtHeader(signingCredentials), payload);

            return tokenHandler.WriteToken(token);
        }

        [Serializable]
        private class Sucursal
        {
            public int sucursalId { get; set; }
            public string nombre { get; set; }
            public DateTime fechaCreacion { get; set; }
            public string direccion { get; set; }
            public int paisId { get; set; }
            public string pais { get; set; }

        }
        private class Usuario
        {
            public int usuarioId { get; set; }
            public string nickname { get; set; }
            public string email { get; set; }
            public string rol { get; set; }
            public Sucursal sucursal { get; set; }

        }
    }


}





//var claims = new List<Claim>
//{
//    new Claim("nickName", usuarioDTO.Nickname),
//    new Claim("rol", usuarioDTO.Rol),
//    new Claim("email", usuarioDTO.Email),
//    //new Claim("sucursal", JsonConvert.SerializeObject(sucursal), IdentityServerConstants.ClaimValueTypes.Json)
//};

//var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512);
//var tokenDescriptor = new SecurityTokenDescriptor
//{
//    Subject = new ClaimsIdentity(claims),
//    Expires = DateTime.Now.AddDays(1),
//    SigningCredentials = credentials,
//};

//var tokenHandler = new JwtSecurityTokenHandler();
//var token = tokenHandler.CreateToken(tokenDescriptor);

//return tokenHandler.WriteToken(token);



//var keybytes = Convert.FromBase64String(YOUR_CLIENT_SECRET);
//var signingCredentials = new SigningCredentials(
//            new InMemorySymmetricSecurityKey(keybytes),
//            SecurityAlgorithms.HmacSha256Signature,
//            SecurityAlgorithms.Sha256Digest);

//var nbf = DateTime.UtcNow.AddSeconds(-1);
//var exp = DateTime.UtcNow.AddSeconds(120);
//var payload = new JwtPayload(null, "", new List<Claim>(), nbf, exp);

//var users = new Dictionary<string, object>();
//users.Add("actions", new List<string>() { "read", "create" });
//var scopes = new Dictionary<string, object>();
//scopes.Add("users", users);
//payload.Add("scopes", scopes);

//var jwtToken = new JwtSecurityToken(new JwtHeader(signingCredentials), payload);
//var jwtTokenHandler = new JwtSecurityTokenHandler();
//return jwtTokenHandler.WriteToken(jwtToken);


