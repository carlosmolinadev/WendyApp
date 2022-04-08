
using Microsoft.EntityFrameworkCore;
using WendyApp.Shared.Domain;


namespace Wendy.Server.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) 
        {}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<EstadoPedido> EstadoPedidos { get; set; }
        public DbSet<HistorialPedidoDTO> HistorialPedidos { get; set; }
        public DbSet<InsumoDTO> Insumos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<PedidoDTO> Pedidos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.ApplyConfiguration(new ColourSeedConfiguration());
        //    builder.ApplyConfiguration(new MakeSeedConfiguration());
        //    builder.ApplyConfiguration(new ModelSeedConfiguration());
        //    builder.ApplyConfiguration(new RoleSeedConfiguration());
        //    builder.ApplyConfiguration(new UserSeedConfiguration());
        //    builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        //}
    }
}
