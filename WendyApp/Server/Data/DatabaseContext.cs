
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
        public DbSet<HistorialPedido> HistorialPedidos { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<PaisProveedor> PaisesProveedores { get; set; }
        public DbSet<PedidoInsumo> PedidosInsumos { get; set; }
        public DbSet<InsumoCategoria> InsumosCategorias { get; set; }
        public DbSet<ProveedorInsumo> ProveedoresInsumos { get; set; }

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
