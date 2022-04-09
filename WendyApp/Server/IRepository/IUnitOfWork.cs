using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Categoria> Categorias { get; }
        IGenericRepository<EstadoPedido> EstadoPedidos { get; }
        IGenericRepository<HistorialPedido> HistorialPedidos { get; }
        IGenericRepository<Insumo> Insumos { get; }
        IGenericRepository<Pais> Paises { get; }
        IGenericRepository<Pedido> Pedidos { get; }
        IGenericRepository<Proveedor> Proveedores { get; }
        IGenericRepository<Sucursal> Sucursales { get; }
        IGenericRepository<Usuario> Usuarios { get; }
        IGenericRepository<InsumoCategoria> InsumosCategorias { get; }
        Task Save();
    }
}
