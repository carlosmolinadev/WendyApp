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
            CreateMap<InsumoCategoria, InsumoCategoriaDTO>().ReverseMap();
            CreateMap<Pais, PaisDTO>().ReverseMap();
            CreateMap<PaisProveedor, PaisProveedorDTO>().ReverseMap();
            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<PedidoInsumo, PedidoInsumoDTO>().ReverseMap();
            CreateMap<Proveedor, ProveedorDTO>().ReverseMap();
            CreateMap<ProveedorInsumo, ProveedorInsumoDTO>().ReverseMap();
            CreateMap<Sucursal, SucursalDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDisplayDTO>().ReverseMap();

        }
    }
}
