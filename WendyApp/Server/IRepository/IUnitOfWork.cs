using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Pais> Paises { get; }
        IGenericRepository<Sucursal> Sucursales { get; }
        IGenericRepository<Usuario> Usuarios { get; }
        Task Save();
    }
}
