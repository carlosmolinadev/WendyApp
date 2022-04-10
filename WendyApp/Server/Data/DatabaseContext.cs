
using Microsoft.EntityFrameworkCore;
using WendyApp.Server.Configuration.Entities;
using WendyApp.Shared.Domain;


namespace Wendy.Server.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsumoCategoria>()
                .HasOne(ic => ic.Categoria)
                .WithMany(i => i.Insumos)
                .HasForeignKey(ic => ic.CategoriaId);

            modelBuilder.Entity<InsumoCategoria>()
                .HasOne(i => i.Insumo)
                .WithMany(c => c.Categorias)
                .HasForeignKey(i => i.InsumoId);

            modelBuilder.Entity<PedidoInsumo>()
                .HasOne(i => i.Insumo)
                .WithMany(p => p.Pedidos)
                .HasForeignKey(i => i.InsumoId);

            modelBuilder.Entity<PedidoInsumo>()
                .HasOne(p => p.Pedido)
                .WithMany(i => i.Insumos)
                .HasForeignKey(p => p.PedidoId);

            modelBuilder.Entity<PaisProveedor>()
                .HasOne(pa => pa.Pais)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.PaisId);

            modelBuilder.Entity<PaisProveedor>()
                .HasOne(p => p.Proveedor)
                .WithMany(pa => pa.Paises)
                .HasForeignKey(p => p.ProveedorId);

            modelBuilder.Entity<ProveedorInsumo>()
                .HasOne(p => p.Proveedor)
                .WithMany(i => i.Insumos)
                .HasForeignKey(p => p.ProveedorId);

            modelBuilder.Entity<ProveedorInsumo>()
                .HasOne(i => i.Insumo)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(i => i.InsumoId);

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new SucursalConfiguration());
        }

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
