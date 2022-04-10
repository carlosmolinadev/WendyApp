using WendyApp.Server.Models;

namespace WendyApp.Server.Interfaces.IServices
{
    public interface ITokenService
    {
        string CreateToken(UsuarioDTO usuarioDTO);
    }
}
