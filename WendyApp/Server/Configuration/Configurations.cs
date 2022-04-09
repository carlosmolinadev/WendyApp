using AutoMapper;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Configuration
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Categoria, CategoriaDTO>();
            CreateMap<EstadoPedido, EstadoPedidoDTO>();
            CreateMap<HistorialPedido, HistorialPedidoDTO>();
            CreateMap<Insumo, InsumoDTO>();
            CreateMap<Pais, PaisDTO>();
            CreateMap<Pedido, PedidoDTO>();
            CreateMap<Proveedor, ProveedorDTO>();
            CreateMap<Sucursal, SucursalDTO>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<InsumoCategoria, InsumoCategoriaDTO>().ReverseMap();
        }
    }
}
