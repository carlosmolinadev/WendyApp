using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendyApp.Shared.Domain;
using Wendy.Server.Data;
using WendyApp.Server.Interfaces.IRepository;

namespace WendyApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        
        private IGenericRepository<Categoria> _categorias;
        private IGenericRepository<EstadoPedido> _estadoPedidos;
        private IGenericRepository<HistorialPedido> _historialPedidos;
        private IGenericRepository<Insumo> _insumos;
        private IGenericRepository<Pais> _paises;
        private IGenericRepository<Pedido> _pedidos;
        private IGenericRepository<Proveedor> _proveedores;
        private IGenericRepository<Sucursal> _sucursales;
        private IGenericRepository<Usuario> _usuarios;
        private IGenericRepository<InsumoCategoria> _insumosCategorias;
        private IGenericRepository<PaisProveedor> _paisesProveedores;
        private IGenericRepository<PedidoInsumo> _pedidosInsumos;
        private IGenericRepository<ProveedorInsumo> _proveedoresInsumos;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Categoria> Categorias => _categorias ??= new GenericRepository<Categoria>(_context);

        public IGenericRepository<EstadoPedido> EstadoPedidos => _estadoPedidos ??= new GenericRepository<EstadoPedido>(_context);

        public IGenericRepository<HistorialPedido> HistorialPedidos => _historialPedidos ??= new GenericRepository<HistorialPedido>(_context);

        public IGenericRepository<Insumo> Insumos => _insumos ??= new GenericRepository<Insumo>(_context);

        public IGenericRepository<Pais> Paises => _paises ??= new GenericRepository<Pais>(_context);

        public IGenericRepository<Pedido> Pedidos => _pedidos ??= new GenericRepository<Pedido>(_context);

        public IGenericRepository<Proveedor> Proveedores => _proveedores ??= new GenericRepository<Proveedor>(_context);

        public IGenericRepository<Sucursal> Sucursales => _sucursales ??= new GenericRepository<Sucursal>(_context);

        public IGenericRepository<Usuario> Usuarios => _usuarios ??= new GenericRepository<Usuario>(_context);

        public IGenericRepository<InsumoCategoria> InsumosCategorias => _insumosCategorias ??= new GenericRepository<InsumoCategoria>(_context);

        public IGenericRepository<PaisProveedor> PaisesProveedores => _paisesProveedores ??= new GenericRepository<PaisProveedor>(_context);

        public IGenericRepository<PedidoInsumo> PedidosInsumos => _pedidosInsumos ??= new GenericRepository<PedidoInsumo>(_context);

        public IGenericRepository<ProveedorInsumo> ProveedoresInsumos => _proveedoresInsumos ??= new GenericRepository<ProveedorInsumo>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
