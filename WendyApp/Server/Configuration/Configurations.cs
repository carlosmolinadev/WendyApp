using AutoMapper;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Configuration
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<EstadoPedido, EstadoPedidoDTO>().ReverseMap();
            CreateMap<HistorialPedido, HistorialPedidoDTO>().ReverseMap();
            CreateMap<Insumo, InsumoDTO>().ReverseMap();
            CreateMap<Pais, PaisDTO>().ReverseMap();
            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<Proveedor, ProveedorDTO>().ReverseMap();
            CreateMap<Sucursal, SucursalDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<InsumoCategoria, InsumoCategoriaDTO>().ReverseMap();
        }
    }
}
