using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Interfaces.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Categoria> Categorias { get; }
        IGenericRepository<EstadoPedido> EstadoPedidos { get; }
        IGenericRepository<HistorialPedido> HistorialPedidos { get; }
        IGenericRepository<Insumo> Insumos { get; }
        IGenericRepository<InsumoCategoria> InsumosCategorias { get; }
        IGenericRepository<Pais> Paises { get; }
        IGenericRepository<PaisProveedor> PaisesProveedores { get; }
        IGenericRepository<Pedido> Pedidos { get; }
        IGenericRepository<PedidoInsumo> PedidosInsumos { get; }
        IGenericRepository<Proveedor> Proveedores { get; }
        IGenericRepository<ProveedorInsumo> ProveedoresInsumos { get; }
        IGenericRepository<Sucursal> Sucursales { get; }
        IGenericRepository<Usuario> Usuarios { get; }

        Task Save();
    }
}
