using WendyApp.Server.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendyApp.Shared.Domain;
using Wendy.Server.Data;

namespace WendyApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Pais> _paises;
        private IGenericRepository<Sucursal> _sucursales;
        private IGenericRepository<Usuario> _usuarios;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Pais> Paises => _paises ??= new GenericRepository<Pais>(_context);

        public IGenericRepository<Sucursal> Sucursales => _sucursales ??= new GenericRepository<Sucursal>(_context);

        public IGenericRepository<Usuario> Usuarios => _usuarios ??= new GenericRepository<Usuario>(_context);

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
