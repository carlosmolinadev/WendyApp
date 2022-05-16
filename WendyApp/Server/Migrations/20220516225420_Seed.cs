using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPedidos",
                columns: table => new
                {
                    EstadoPedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedidos", x => x.EstadoPedidoId);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descripcion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.InsumoId);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descripcion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "InsumosCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumosCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsumosCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumosCategorias_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    SucursalId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Direccion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PaisId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.SucursalId);
                    table.ForeignKey(
                        name: "FK_Sucursales_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaisesProveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CostoTransporte = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    PaisId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisesProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaisesProveedores_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisesProveedores_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedoresInsumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Precio = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedoresInsumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProveedoresInsumos_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProveedoresInsumos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FechaEntrega = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SucursalId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EstadoPedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadoPedidos_EstadoPedidoId",
                        column: x => x.EstadoPedidoId,
                        principalTable: "EstadoPedidos",
                        principalColumn: "EstadoPedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nickname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Password = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Rol = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SucursalId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Descripcion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EstadoPedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidoId",
                        column: x => x.EstadoPedidoId,
                        principalTable: "EstadoPedidos",
                        principalColumn: "EstadoPedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosInsumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Cantidad = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Precio = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosInsumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosInsumos_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosInsumos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Vegetales" },
                    { 2, "Carnes" },
                    { 3, "Pan" },
                    { 4, "Lacteos" },
                    { 5, "Especias y condimentos" },
                    { 6, "Bebidas" },
                    { 7, "Electrodomésticos" },
                    { 8, "Servicios básicos" },
                    { 9, "Papel" },
                    { 10, "Cajas y Bolsas" },
                    { 11, "Mobiliario" },
                    { 12, "Vajilla y similares" },
                    { 13, "Artículos de Limpueza" },
                    { 14, "Otros" }
                });

            migrationBuilder.InsertData(
                table: "EstadoPedidos",
                columns: new[] { "EstadoPedidoId", "Estado" },
                values: new object[,]
                {
                    { 5, "Recibida" },
                    { 4, "Cancelada" },
                    { 1, "Enviada" },
                    { 2, "Aprobada" },
                    { 3, "Despachada" }
                });

            migrationBuilder.InsertData(
                table: "Insumos",
                columns: new[] { "InsumoId", "Descripcion", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { 33, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3091), "Sillas" },
                    { 25, "Precio por Kw/hora", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3070), "Electricidad" },
                    { 26, "Precio por megas", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3073), "Internet" },
                    { 27, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3076), "Servilletas" },
                    { 28, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3079), "Papel higiénico" },
                    { 29, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3081), "Toallas del hogar" },
                    { 30, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3084), "Empaques desechables" },
                    { 31, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3086), "Bolsas para llevar" },
                    { 32, "Precio por Unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3089), "Mesas" },
                    { 34, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3094), "Lámparas - iluminación" },
                    { 44, "Precio por galón", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3119), "Jabbón para manos" },
                    { 36, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3099), "Vasos" },
                    { 37, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3101), "Cucharas" },
                    { 38, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3104), "Tenedores" },
                    { 39, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3106), "Cuchillos" },
                    { 40, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3109), "Escobas" },
                    { 41, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3111), "Trapeadores" },
                    { 42, "Precio por galón", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3114), "Detergentes y desinfectantes" },
                    { 24, "Precio por metro cúbico", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3031), "Agua" },
                    { 45, "Precio por tipo de insumo", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3121), "Otros" },
                    { 35, "Precio por paquete", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3096), "Platos" },
                    { 23, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3029), "Utensilios de cocina" },
                    { 43, "Precio por galón", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3116), "Alcohol gel" }
                });

            migrationBuilder.InsertData(
                table: "Insumos",
                columns: new[] { "InsumoId", "Descripcion", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { 21, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3024), "Freidora" },
                    { 22, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3026), "Cuarto frío" },
                    { 1, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2653), "Tomate" },
                    { 2, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2976), "Lechuga" },
                    { 3, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2979), "Cebolla" },
                    { 5, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2984), "Papas" },
                    { 6, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2986), "Carne de Res" },
                    { 7, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2989), "Carne de Pollo" },
                    { 8, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2991), "Tocino" },
                    { 9, "Precio por bolsa", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2994), "Pan con ajonjolí" },
                    { 10, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2996), "Queso" },
                    { 4, "Precio por frasco", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2981), "Pepinillo" },
                    { 12, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3001), "Salsa de Tomate" },
                    { 13, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3004), "Mostaza" },
                    { 14, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3006), "Salsa Sandwich Spread" },
                    { 15, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3009), "Sal" },
                    { 16, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3011), "Pimienta" },
                    { 17, "Precio por botella", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3014), "Agua" },
                    { 20, "Precio por unidad", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3021), "Cocina" },
                    { 18, "Precio por libra", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3016), "Café" },
                    { 19, "Precio por litro", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(3019), "Soda" },
                    { 11, "Precio por litro", new DateTime(2022, 5, 16, 16, 54, 19, 737, DateTimeKind.Local).AddTicks(2999), "Leche" }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "PaisId", "Nombre" },
                values: new object[,]
                {
                    { 18, "Nicaragua" },
                    { 20, "Rusia" },
                    { 21, "Austria" },
                    { 22, "Suecia" },
                    { 23, "Francia" },
                    { 28, "Italia" },
                    { 25, "Reino Unido" },
                    { 26, "Irlanda" },
                    { 27, "Alemania" },
                    { 29, "Grecia" },
                    { 30, "Bélgica" },
                    { 17, "Honduras" },
                    { 24, "Portugal" },
                    { 16, "República Dominicana" },
                    { 19, "España" },
                    { 14, "Perú" },
                    { 1, "El Salvador" },
                    { 2, "Guatemala" },
                    { 3, "Costa Rica" },
                    { 4, "Brasil" }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "PaisId", "Nombre" },
                values: new object[,]
                {
                    { 15, "Paraguay" },
                    { 6, "Argentina" },
                    { 5, "México" },
                    { 8, "Puerto Rico" },
                    { 9, "Chile" },
                    { 10, "Colombia" },
                    { 11, "Panamá" },
                    { 12, "Uruguay" },
                    { 13, "Ecuador" },
                    { 7, "Venezuela" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Descripcion", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { 17, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3603), "Supermercado Paiz - Honduras" },
                    { 18, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3605), "Supermercado La Unión - Nicaragua" },
                    { 19, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3606), "Supermercados Día - España" },
                    { 20, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3608), "Supermercado Auchan - Rusia" },
                    { 21, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3609), "Supermercado Hofer - Austria" },
                    { 28, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3658), "Supermercado Esselung - Italia" },
                    { 23, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3612), "Supermercado Leclerc - Francia" },
                    { 24, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3613), "Corporación Froiz - Portugal" },
                    { 25, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3615), "Supermercado Tesco - Reino Unido" },
                    { 26, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3654), "Supermercado Spr - Irlanda" },
                    { 27, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3656), "Supermercados Aldi - Alemania" },
                    { 16, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3602), "Supermercados Nacional - República Dominicana" },
                    { 22, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3610), "Ica Supermarket - Suecia" },
                    { 15, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3601), "Supermercado Plaza Vea - Perú" },
                    { 8, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3591), "Supermax - Puerto Rico" },
                    { 13, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3598), "Corporación Favorita - Ecuador" },
                    { 12, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3597), "Supermercado Pingüino - Uruguay" },
                    { 11, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3595), "Super 99 - Panamá" },
                    { 10, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3594), "Supermercado El Soll S A S - Colombia" },
                    { 9, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3592), "Jumbo - Chile" },
                    { 7, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3590), "Supermercado y Frutería California - Venezuela" },
                    { 6, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3588), "Carrefour - Argentina" },
                    { 5, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3587), "Walmart Express - México" },
                    { 4, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3583), "Supermercado Brasil - Brasil" },
                    { 3, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3582), "Supermercado Saretto - Costa Rica" },
                    { 2, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3576), "Supermercado La Torre Centro Histórico - Guatemala" },
                    { 1, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(2701), "Super selectos - El Salvador" },
                    { 29, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3659), "Supermercado Msoutis - Grecia" },
                    { 14, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3599), "Supermercado La Torre Centro Histórico" },
                    { 30, "Distribuidor de carnes, pan y vegetales", new DateTime(2022, 5, 16, 16, 54, 19, 735, DateTimeKind.Local).AddTicks(3660), "Supermercado Amarás el Colruyt - Bélgica" }
                });

            migrationBuilder.InsertData(
                table: "InsumosCategorias",
                columns: new[] { "Id", "CategoriaId", "InsumoId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 26, 8, 26 },
                    { 27, 9, 27 },
                    { 28, 9, 28 },
                    { 29, 9, 29 },
                    { 30, 10, 30 },
                    { 31, 10, 31 },
                    { 32, 11, 32 },
                    { 33, 11, 33 },
                    { 34, 11, 34 },
                    { 35, 12, 35 },
                    { 37, 12, 37 },
                    { 38, 12, 38 },
                    { 39, 12, 39 },
                    { 40, 13, 40 },
                    { 41, 13, 41 },
                    { 42, 13, 42 },
                    { 43, 13, 43 },
                    { 44, 13, 44 },
                    { 45, 14, 45 },
                    { 25, 8, 25 },
                    { 24, 8, 24 },
                    { 36, 12, 36 },
                    { 22, 14, 22 },
                    { 23, 7, 23 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 8, 2, 8 },
                    { 9, 3, 9 },
                    { 10, 4, 10 },
                    { 11, 4, 11 },
                    { 7, 2, 7 },
                    { 13, 5, 13 },
                    { 14, 5, 14 },
                    { 15, 5, 15 },
                    { 16, 5, 16 },
                    { 17, 6, 17 },
                    { 18, 6, 18 },
                    { 19, 6, 19 }
                });

            migrationBuilder.InsertData(
                table: "InsumosCategorias",
                columns: new[] { "Id", "CategoriaId", "InsumoId" },
                values: new object[,]
                {
                    { 20, 7, 20 },
                    { 12, 5, 12 },
                    { 21, 7, 21 }
                });

            migrationBuilder.InsertData(
                table: "PaisesProveedores",
                columns: new[] { "Id", "CostoTransporte", "PaisId", "ProveedorId" },
                values: new object[,]
                {
                    { 1, 2.0m, 1, 1 },
                    { 19, 5.0m, 19, 19 },
                    { 3, 3.0m, 3, 3 },
                    { 12, 4.0m, 12, 12 },
                    { 28, 6.5m, 28, 28 },
                    { 17, 3.0m, 17, 17 },
                    { 2, 2.2m, 2, 2 },
                    { 13, 3.5m, 13, 13 },
                    { 29, 9.0m, 29, 29 },
                    { 27, 8.0m, 27, 27 },
                    { 18, 2.5m, 18, 18 },
                    { 11, 4.5m, 11, 11 },
                    { 24, 7.0m, 24, 24 },
                    { 20, 6.0m, 20, 20 },
                    { 26, 7.5m, 26, 26 },
                    { 5, 3.5m, 5, 5 },
                    { 10, 4.0m, 10, 10 },
                    { 21, 5.5m, 21, 21 },
                    { 25, 6.5m, 25, 25 },
                    { 6, 4.0m, 6, 6 },
                    { 9, 3.0m, 9, 9 },
                    { 22, 8.0m, 22, 22 },
                    { 7, 4.0m, 7, 7 },
                    { 8, 2.0m, 8, 8 },
                    { 15, 2.0m, 15, 14 },
                    { 4, 2.5m, 4, 4 },
                    { 30, 6.0m, 30, 30 },
                    { 23, 7.5m, 23, 23 },
                    { 16, 6.0m, 16, 16 },
                    { 14, 2.5m, 14, 15 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 908, 33, 15m, 20 },
                    { 907, 32, 55m, 20 },
                    { 906, 31, 2.1m, 20 },
                    { 905, 30, 2.45m, 20 },
                    { 658, 28, 9.28m, 15 },
                    { 904, 29, 5.26m, 20 },
                    { 659, 29, 5.26m, 15 },
                    { 903, 28, 9.28m, 20 },
                    { 902, 27, 1.55m, 20 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 901, 26, 0.1m, 20 },
                    { 900, 25, 0.1m, 20 },
                    { 899, 24, 0.05m, 20 },
                    { 898, 23, 1.69m, 20 },
                    { 897, 22, 1275.85m, 20 },
                    { 896, 21, 532.58m, 20 },
                    { 895, 20, 345.8m, 20 },
                    { 909, 34, 25m, 20 },
                    { 910, 35, 1.47m, 20 },
                    { 911, 36, 1.24m, 20 },
                    { 912, 37, 0.45m, 20 },
                    { 928, 8, 1.1m, 21 },
                    { 927, 7, 1.45m, 21 },
                    { 926, 6, 3.3m, 21 },
                    { 656, 26, 0.1m, 15 },
                    { 925, 5, 0.53m, 21 },
                    { 924, 4, 3.4m, 21 },
                    { 923, 3, 0.45m, 21 },
                    { 922, 2, 0.25m, 21 },
                    { 894, 19, 0.95m, 20 },
                    { 921, 1, 0.3m, 21 },
                    { 920, 45, 1.5m, 20 },
                    { 919, 44, 7.92m, 20 },
                    { 918, 43, 8.75m, 20 },
                    { 917, 42, 9.83m, 20 },
                    { 916, 41, 4.75m, 20 },
                    { 915, 40, 4.75m, 20 },
                    { 914, 39, 0.45m, 20 },
                    { 913, 38, 0.45m, 20 },
                    { 657, 27, 1.55m, 15 },
                    { 893, 18, 1.05m, 20 },
                    { 892, 17, 0.5m, 20 },
                    { 891, 16, 0.53m, 20 },
                    { 870, 40, 4.75m, 19 },
                    { 869, 39, 0.45m, 19 },
                    { 868, 38, 0.45m, 19 },
                    { 867, 37, 0.45m, 19 },
                    { 866, 36, 1.24m, 19 },
                    { 865, 35, 1.47m, 19 },
                    { 864, 34, 25m, 19 },
                    { 863, 33, 15m, 19 },
                    { 862, 32, 55m, 19 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 861, 31, 2.1m, 19 },
                    { 662, 32, 55m, 15 },
                    { 663, 33, 15m, 15 },
                    { 860, 30, 2.45m, 19 },
                    { 859, 29, 5.26m, 19 },
                    { 858, 28, 9.28m, 19 },
                    { 857, 27, 1.55m, 19 },
                    { 856, 26, 0.1m, 19 },
                    { 871, 41, 4.75m, 19 },
                    { 872, 42, 9.83m, 19 },
                    { 873, 43, 8.75m, 19 },
                    { 874, 44, 7.92m, 19 },
                    { 890, 15, 0.48m, 20 },
                    { 889, 14, 2.94m, 20 },
                    { 888, 13, 2.68m, 20 },
                    { 887, 12, 2.75m, 20 },
                    { 886, 11, 2.11m, 20 },
                    { 885, 10, 1.62m, 20 },
                    { 884, 9, 3.25m, 20 },
                    { 883, 8, 1.1m, 20 },
                    { 929, 9, 3.25m, 21 },
                    { 660, 30, 2.45m, 15 },
                    { 881, 6, 3.3m, 20 },
                    { 880, 5, 0.53m, 20 },
                    { 879, 4, 3.4m, 20 },
                    { 878, 3, 0.45m, 20 },
                    { 877, 2, 0.25m, 20 },
                    { 876, 1, 0.3m, 20 },
                    { 661, 31, 2.1m, 15 },
                    { 875, 45, 1.5m, 19 },
                    { 882, 7, 1.45m, 20 },
                    { 930, 10, 1.62m, 21 },
                    { 931, 11, 2.11m, 21 },
                    { 932, 12, 2.75m, 21 },
                    { 988, 23, 1.69m, 22 },
                    { 651, 21, 532.58m, 15 },
                    { 987, 22, 1275.85m, 22 },
                    { 986, 21, 532.58m, 22 },
                    { 985, 20, 345.8m, 22 },
                    { 984, 19, 0.95m, 22 },
                    { 983, 18, 1.05m, 22 },
                    { 982, 17, 0.5m, 22 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 981, 16, 0.53m, 22 },
                    { 980, 15, 0.48m, 22 },
                    { 979, 14, 2.94m, 22 },
                    { 978, 13, 2.68m, 22 },
                    { 977, 12, 2.75m, 22 },
                    { 976, 11, 2.11m, 22 },
                    { 975, 10, 1.62m, 22 },
                    { 974, 9, 3.25m, 22 },
                    { 973, 8, 1.1m, 22 },
                    { 989, 24, 0.05m, 22 },
                    { 990, 25, 0.1m, 22 },
                    { 991, 26, 0.1m, 22 },
                    { 992, 27, 1.55m, 22 },
                    { 1009, 44, 7.92m, 22 },
                    { 1008, 43, 8.75m, 22 },
                    { 1007, 42, 9.83m, 22 },
                    { 1006, 41, 4.75m, 22 },
                    { 1005, 40, 4.75m, 22 },
                    { 1004, 39, 0.45m, 22 },
                    { 1003, 38, 0.45m, 22 },
                    { 1002, 37, 0.45m, 22 },
                    { 972, 7, 1.45m, 22 },
                    { 1001, 36, 1.24m, 22 },
                    { 999, 34, 25m, 22 },
                    { 998, 33, 15m, 22 },
                    { 997, 32, 55m, 22 },
                    { 996, 31, 2.1m, 22 },
                    { 995, 30, 2.45m, 22 },
                    { 994, 29, 5.26m, 22 },
                    { 993, 28, 9.28m, 22 },
                    { 650, 20, 345.8m, 15 },
                    { 1000, 35, 1.47m, 22 },
                    { 971, 6, 3.3m, 22 },
                    { 970, 5, 0.53m, 22 },
                    { 969, 4, 3.4m, 22 },
                    { 654, 24, 0.05m, 15 },
                    { 948, 28, 9.28m, 21 },
                    { 947, 27, 1.55m, 21 },
                    { 946, 26, 0.1m, 21 },
                    { 655, 25, 0.1m, 15 },
                    { 945, 25, 0.1m, 21 },
                    { 944, 24, 0.05m, 21 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 943, 23, 1.69m, 21 },
                    { 949, 29, 5.26m, 21 },
                    { 942, 22, 1275.85m, 21 },
                    { 940, 20, 345.8m, 21 },
                    { 939, 19, 0.95m, 21 },
                    { 938, 18, 1.05m, 21 },
                    { 937, 17, 0.5m, 21 },
                    { 936, 16, 0.53m, 21 },
                    { 935, 15, 0.48m, 21 },
                    { 934, 14, 2.94m, 21 },
                    { 933, 13, 2.68m, 21 },
                    { 941, 21, 532.58m, 21 },
                    { 855, 25, 0.1m, 19 },
                    { 950, 30, 2.45m, 21 },
                    { 952, 32, 55m, 21 },
                    { 652, 22, 1275.85m, 15 },
                    { 968, 3, 0.45m, 22 },
                    { 967, 2, 0.25m, 22 },
                    { 966, 1, 0.3m, 22 },
                    { 653, 23, 1.69m, 15 },
                    { 965, 45, 1.5m, 21 },
                    { 964, 44, 7.92m, 21 },
                    { 963, 43, 8.75m, 21 },
                    { 951, 31, 2.1m, 21 },
                    { 962, 42, 9.83m, 21 },
                    { 960, 40, 4.75m, 21 },
                    { 959, 39, 0.45m, 21 },
                    { 958, 38, 0.45m, 21 },
                    { 957, 37, 0.45m, 21 },
                    { 956, 36, 1.24m, 21 },
                    { 955, 35, 1.47m, 21 },
                    { 954, 34, 25m, 21 },
                    { 953, 33, 15m, 21 },
                    { 961, 41, 4.75m, 21 },
                    { 676, 1, 0.3m, 16 },
                    { 854, 24, 0.05m, 19 },
                    { 852, 22, 1275.85m, 19 },
                    { 732, 12, 2.75m, 17 },
                    { 731, 11, 2.11m, 17 },
                    { 730, 10, 1.62m, 17 },
                    { 729, 9, 3.25m, 17 },
                    { 728, 8, 1.1m, 17 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 727, 7, 1.45m, 17 },
                    { 726, 6, 3.3m, 17 },
                    { 725, 5, 0.53m, 17 },
                    { 724, 4, 3.4m, 17 },
                    { 723, 3, 0.45m, 17 },
                    { 722, 2, 0.25m, 17 },
                    { 721, 1, 0.3m, 17 },
                    { 672, 42, 9.83m, 15 },
                    { 720, 45, 1.5m, 16 },
                    { 719, 44, 7.92m, 16 },
                    { 718, 43, 8.75m, 16 },
                    { 717, 42, 9.83m, 16 },
                    { 733, 13, 2.68m, 17 },
                    { 716, 41, 4.75m, 16 },
                    { 671, 41, 4.75m, 15 },
                    { 735, 15, 0.48m, 17 },
                    { 752, 32, 55m, 17 },
                    { 751, 31, 2.1m, 17 },
                    { 750, 30, 2.45m, 17 },
                    { 749, 29, 5.26m, 17 },
                    { 748, 28, 9.28m, 17 },
                    { 747, 27, 1.55m, 17 },
                    { 746, 26, 0.1m, 17 },
                    { 745, 25, 0.1m, 17 },
                    { 744, 24, 0.05m, 17 },
                    { 743, 23, 1.69m, 17 },
                    { 742, 22, 1275.85m, 17 },
                    { 741, 21, 532.58m, 17 },
                    { 740, 20, 345.8m, 17 },
                    { 739, 19, 0.95m, 17 },
                    { 738, 18, 1.05m, 17 },
                    { 737, 17, 0.5m, 17 },
                    { 736, 16, 0.53m, 17 },
                    { 734, 14, 2.94m, 17 },
                    { 715, 40, 4.75m, 16 },
                    { 673, 43, 8.75m, 15 },
                    { 714, 39, 0.45m, 16 },
                    { 692, 17, 0.5m, 16 },
                    { 691, 16, 0.53m, 16 },
                    { 675, 45, 1.5m, 15 },
                    { 690, 15, 0.48m, 16 },
                    { 689, 14, 2.94m, 16 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 688, 13, 2.68m, 16 },
                    { 687, 12, 2.75m, 16 },
                    { 686, 11, 2.11m, 16 },
                    { 685, 10, 1.62m, 16 },
                    { 684, 9, 3.25m, 16 },
                    { 683, 8, 1.1m, 16 },
                    { 682, 7, 1.45m, 16 },
                    { 681, 6, 3.3m, 16 },
                    { 680, 5, 0.53m, 16 },
                    { 679, 4, 3.4m, 16 },
                    { 678, 3, 0.45m, 16 },
                    { 677, 2, 0.25m, 16 },
                    { 693, 18, 1.05m, 16 },
                    { 694, 19, 0.95m, 16 },
                    { 695, 20, 345.8m, 16 },
                    { 696, 21, 532.58m, 16 },
                    { 713, 38, 0.45m, 16 },
                    { 712, 37, 0.45m, 16 },
                    { 711, 36, 1.24m, 16 },
                    { 710, 35, 1.47m, 16 },
                    { 709, 34, 25m, 16 },
                    { 674, 44, 7.92m, 15 },
                    { 708, 33, 15m, 16 },
                    { 707, 32, 55m, 16 },
                    { 670, 40, 4.75m, 15 },
                    { 706, 31, 2.1m, 16 },
                    { 704, 29, 5.26m, 16 },
                    { 703, 28, 9.28m, 16 },
                    { 702, 27, 1.55m, 16 },
                    { 701, 26, 0.1m, 16 },
                    { 700, 25, 0.1m, 16 },
                    { 699, 24, 0.05m, 16 },
                    { 698, 23, 1.69m, 16 },
                    { 697, 22, 1275.85m, 16 },
                    { 705, 30, 2.45m, 16 },
                    { 753, 33, 15m, 17 },
                    { 754, 34, 25m, 17 },
                    { 755, 35, 1.47m, 17 },
                    { 830, 45, 1.5m, 18 },
                    { 829, 44, 7.92m, 18 },
                    { 828, 43, 8.75m, 18 },
                    { 827, 42, 9.83m, 18 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 826, 41, 4.75m, 18 },
                    { 825, 40, 4.75m, 18 },
                    { 824, 39, 0.45m, 18 },
                    { 823, 38, 0.45m, 18 },
                    { 822, 37, 0.45m, 18 },
                    { 821, 36, 1.24m, 18 },
                    { 820, 35, 1.47m, 18 },
                    { 1010, 45, 1.5m, 22 },
                    { 665, 35, 1.47m, 15 },
                    { 818, 33, 15m, 18 },
                    { 817, 32, 55m, 18 },
                    { 666, 36, 1.24m, 15 },
                    { 816, 31, 2.1m, 18 },
                    { 831, 1, 0.3m, 19 },
                    { 832, 2, 0.25m, 19 },
                    { 833, 3, 0.45m, 19 },
                    { 834, 4, 3.4m, 19 },
                    { 851, 21, 532.58m, 19 },
                    { 850, 20, 345.8m, 19 },
                    { 849, 19, 0.95m, 19 },
                    { 848, 18, 1.05m, 19 },
                    { 847, 17, 0.5m, 19 },
                    { 846, 16, 0.53m, 19 },
                    { 845, 15, 0.48m, 19 },
                    { 844, 14, 2.94m, 19 },
                    { 815, 30, 2.45m, 18 },
                    { 843, 13, 2.68m, 19 },
                    { 841, 11, 2.11m, 19 },
                    { 840, 10, 1.62m, 19 },
                    { 664, 34, 25m, 15 },
                    { 839, 9, 3.25m, 19 },
                    { 838, 8, 1.1m, 19 },
                    { 837, 7, 1.45m, 19 },
                    { 836, 6, 3.3m, 19 },
                    { 835, 5, 0.53m, 19 },
                    { 842, 12, 2.75m, 19 },
                    { 853, 23, 1.69m, 19 },
                    { 814, 29, 5.26m, 18 },
                    { 812, 27, 1.55m, 18 },
                    { 770, 5, 0.53m, 18 },
                    { 769, 4, 3.4m, 18 },
                    { 768, 3, 0.45m, 18 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 767, 2, 0.25m, 18 },
                    { 766, 1, 0.3m, 18 },
                    { 668, 38, 0.45m, 15 },
                    { 765, 45, 1.5m, 17 },
                    { 764, 44, 7.92m, 17 },
                    { 763, 43, 8.75m, 17 },
                    { 762, 42, 9.83m, 17 },
                    { 761, 41, 4.75m, 17 },
                    { 760, 40, 4.75m, 17 },
                    { 759, 39, 0.45m, 17 },
                    { 758, 38, 0.45m, 17 },
                    { 757, 37, 0.45m, 17 },
                    { 669, 39, 0.45m, 15 },
                    { 756, 36, 1.24m, 17 },
                    { 771, 6, 3.3m, 18 },
                    { 772, 7, 1.45m, 18 },
                    { 773, 8, 1.1m, 18 },
                    { 774, 9, 3.25m, 18 },
                    { 811, 26, 0.1m, 18 },
                    { 810, 25, 0.1m, 18 },
                    { 809, 24, 0.05m, 18 },
                    { 808, 23, 1.69m, 18 },
                    { 807, 22, 1275.85m, 18 },
                    { 806, 21, 532.58m, 18 },
                    { 805, 20, 345.8m, 18 },
                    { 804, 19, 0.95m, 18 },
                    { 813, 28, 9.28m, 18 },
                    { 803, 18, 1.05m, 18 },
                    { 801, 16, 0.53m, 18 },
                    { 800, 15, 0.48m, 18 },
                    { 779, 14, 2.94m, 18 },
                    { 778, 13, 2.68m, 18 },
                    { 777, 12, 2.75m, 18 },
                    { 667, 37, 0.45m, 15 },
                    { 776, 11, 2.11m, 18 },
                    { 775, 10, 1.62m, 18 },
                    { 802, 17, 0.5m, 18 },
                    { 819, 34, 25m, 18 },
                    { 1039, 29, 5.26m, 23 },
                    { 1012, 2, 0.25m, 23 },
                    { 1255, 20, 345.8m, 28 },
                    { 1254, 19, 0.95m, 28 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1253, 18, 1.05m, 28 },
                    { 1252, 17, 0.5m, 28 },
                    { 1251, 16, 0.53m, 28 },
                    { 1250, 15, 0.48m, 28 },
                    { 1249, 14, 2.94m, 28 },
                    { 1248, 13, 2.68m, 28 },
                    { 1256, 21, 532.58m, 28 },
                    { 1247, 12, 2.75m, 28 },
                    { 1245, 10, 1.62m, 28 },
                    { 1244, 9, 3.25m, 28 },
                    { 1243, 8, 1.1m, 28 },
                    { 1242, 7, 1.45m, 28 },
                    { 1241, 6, 3.3m, 28 },
                    { 1240, 5, 0.53m, 28 },
                    { 1239, 4, 3.4m, 28 },
                    { 1238, 3, 0.45m, 28 },
                    { 1246, 11, 2.11m, 28 },
                    { 1257, 22, 1275.85m, 28 },
                    { 1258, 23, 1.69m, 28 },
                    { 1259, 24, 0.05m, 28 },
                    { 1278, 43, 8.75m, 28 },
                    { 1277, 42, 9.83m, 28 },
                    { 1276, 41, 4.75m, 28 },
                    { 1275, 40, 4.75m, 28 },
                    { 1274, 39, 0.45m, 28 },
                    { 1273, 38, 0.45m, 28 },
                    { 1272, 37, 0.45m, 28 },
                    { 1271, 36, 1.24m, 28 },
                    { 1270, 35, 1.47m, 28 },
                    { 1269, 34, 25m, 28 },
                    { 1268, 33, 15m, 28 },
                    { 1267, 32, 55m, 28 },
                    { 1266, 31, 2.1m, 28 },
                    { 1265, 30, 2.45m, 28 },
                    { 1264, 29, 5.26m, 28 },
                    { 1263, 28, 9.28m, 28 },
                    { 1262, 27, 1.55m, 28 },
                    { 1261, 26, 0.1m, 28 },
                    { 1260, 25, 0.1m, 28 },
                    { 1237, 2, 0.25m, 28 },
                    { 1279, 44, 7.92m, 28 },
                    { 1236, 1, 0.3m, 28 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1234, 44, 7.92m, 27 },
                    { 1210, 20, 345.8m, 27 },
                    { 1209, 19, 0.95m, 27 },
                    { 1208, 18, 1.05m, 27 },
                    { 1207, 17, 0.5m, 27 },
                    { 1206, 16, 0.53m, 27 },
                    { 1205, 15, 0.48m, 27 },
                    { 1204, 14, 2.94m, 27 },
                    { 1203, 13, 2.68m, 27 },
                    { 1211, 21, 532.58m, 27 },
                    { 1202, 12, 2.75m, 27 },
                    { 1200, 10, 1.62m, 27 },
                    { 1199, 9, 3.25m, 27 },
                    { 1198, 8, 1.1m, 27 },
                    { 1197, 7, 1.45m, 27 },
                    { 1196, 6, 3.3m, 27 },
                    { 1195, 5, 0.53m, 27 },
                    { 1194, 4, 3.4m, 27 },
                    { 1193, 3, 0.45m, 27 },
                    { 1201, 11, 2.11m, 27 },
                    { 1212, 22, 1275.85m, 27 },
                    { 1213, 23, 1.69m, 27 },
                    { 1214, 24, 0.05m, 27 },
                    { 1233, 43, 8.75m, 27 },
                    { 1232, 42, 9.83m, 27 },
                    { 1231, 41, 4.75m, 27 },
                    { 1230, 40, 4.75m, 27 },
                    { 1229, 39, 0.45m, 27 },
                    { 1228, 38, 0.45m, 27 },
                    { 1227, 37, 0.45m, 27 },
                    { 1226, 36, 1.24m, 27 },
                    { 1225, 35, 1.47m, 27 },
                    { 1224, 34, 25m, 27 },
                    { 1223, 33, 15m, 27 },
                    { 1222, 32, 55m, 27 },
                    { 1221, 31, 2.1m, 27 },
                    { 1220, 30, 2.45m, 27 },
                    { 1219, 29, 5.26m, 27 },
                    { 1218, 28, 9.28m, 27 },
                    { 1217, 27, 1.55m, 27 },
                    { 1216, 26, 0.1m, 27 },
                    { 1215, 25, 0.1m, 27 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1235, 45, 1.5m, 27 },
                    { 1192, 2, 0.25m, 27 },
                    { 1280, 45, 1.5m, 28 },
                    { 1282, 2, 0.25m, 29 },
                    { 1345, 20, 345.8m, 30 },
                    { 1344, 19, 0.95m, 30 },
                    { 1343, 18, 1.05m, 30 },
                    { 1342, 17, 0.5m, 30 },
                    { 1341, 16, 0.53m, 30 },
                    { 1340, 15, 0.48m, 30 },
                    { 1339, 14, 2.94m, 30 },
                    { 1338, 13, 2.68m, 30 },
                    { 1346, 21, 532.58m, 30 },
                    { 1337, 12, 2.75m, 30 },
                    { 1335, 10, 1.62m, 30 },
                    { 1334, 9, 3.25m, 30 },
                    { 1333, 8, 1.1m, 30 },
                    { 1332, 7, 1.45m, 30 },
                    { 1331, 6, 3.3m, 30 },
                    { 1330, 5, 0.53m, 30 },
                    { 1329, 4, 3.4m, 30 },
                    { 1328, 3, 0.45m, 30 },
                    { 1336, 11, 2.11m, 30 },
                    { 1347, 22, 1275.85m, 30 },
                    { 1348, 23, 1.69m, 30 },
                    { 1349, 24, 0.05m, 30 },
                    { 1368, 43, 8.75m, 30 },
                    { 1367, 42, 9.83m, 30 },
                    { 1366, 41, 4.75m, 30 },
                    { 1365, 40, 4.75m, 30 },
                    { 1364, 39, 0.45m, 30 },
                    { 1363, 38, 0.45m, 30 },
                    { 1362, 37, 0.45m, 30 },
                    { 1361, 36, 1.24m, 30 },
                    { 1360, 35, 1.47m, 30 },
                    { 1359, 34, 25m, 30 },
                    { 1358, 33, 15m, 30 },
                    { 1357, 32, 55m, 30 },
                    { 1356, 31, 2.1m, 30 },
                    { 1355, 30, 2.45m, 30 },
                    { 1354, 29, 5.26m, 30 },
                    { 1353, 28, 9.28m, 30 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1352, 27, 1.55m, 30 },
                    { 1351, 26, 0.1m, 30 },
                    { 1350, 25, 0.1m, 30 },
                    { 1327, 2, 0.25m, 30 },
                    { 1281, 1, 0.3m, 29 },
                    { 1326, 1, 0.3m, 30 },
                    { 1324, 44, 7.92m, 29 },
                    { 1300, 20, 345.8m, 29 },
                    { 1299, 19, 0.95m, 29 },
                    { 1298, 18, 1.05m, 29 },
                    { 1297, 17, 0.5m, 29 },
                    { 1296, 16, 0.53m, 29 },
                    { 1295, 15, 0.48m, 29 },
                    { 1294, 14, 2.94m, 29 },
                    { 1293, 13, 2.68m, 29 },
                    { 1301, 21, 532.58m, 29 },
                    { 1292, 12, 2.75m, 29 },
                    { 1290, 10, 1.62m, 29 },
                    { 1289, 9, 3.25m, 29 },
                    { 1288, 8, 1.1m, 29 },
                    { 1287, 7, 1.45m, 29 },
                    { 1286, 6, 3.3m, 29 },
                    { 1285, 5, 0.53m, 29 },
                    { 1284, 4, 3.4m, 29 },
                    { 1283, 3, 0.45m, 29 },
                    { 1291, 11, 2.11m, 29 },
                    { 1302, 22, 1275.85m, 29 },
                    { 1303, 23, 1.69m, 29 },
                    { 1304, 24, 0.05m, 29 },
                    { 1323, 43, 8.75m, 29 },
                    { 1322, 42, 9.83m, 29 },
                    { 1321, 41, 4.75m, 29 },
                    { 1320, 40, 4.75m, 29 },
                    { 1319, 39, 0.45m, 29 },
                    { 1318, 38, 0.45m, 29 },
                    { 1317, 37, 0.45m, 29 },
                    { 1316, 36, 1.24m, 29 },
                    { 1315, 35, 1.47m, 29 },
                    { 1314, 34, 25m, 29 },
                    { 1313, 33, 15m, 29 },
                    { 1312, 32, 55m, 29 },
                    { 1311, 31, 2.1m, 29 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1310, 30, 2.45m, 29 },
                    { 1309, 29, 5.26m, 29 },
                    { 1308, 28, 9.28m, 29 },
                    { 1307, 27, 1.55m, 29 },
                    { 1306, 26, 0.1m, 29 },
                    { 1305, 25, 0.1m, 29 },
                    { 1325, 45, 1.5m, 29 },
                    { 1011, 1, 0.3m, 23 },
                    { 1191, 1, 0.3m, 27 },
                    { 1189, 44, 7.92m, 26 },
                    { 1075, 20, 345.8m, 24 },
                    { 1074, 19, 0.95m, 24 },
                    { 1073, 18, 1.05m, 24 },
                    { 1072, 17, 0.5m, 24 },
                    { 1071, 16, 0.53m, 24 },
                    { 1070, 15, 0.48m, 24 },
                    { 1069, 14, 2.94m, 24 },
                    { 1068, 13, 2.68m, 24 },
                    { 1076, 21, 532.58m, 24 },
                    { 1067, 12, 2.75m, 24 },
                    { 1065, 10, 1.62m, 24 },
                    { 1064, 9, 3.25m, 24 },
                    { 1063, 8, 1.1m, 24 },
                    { 1062, 7, 1.45m, 24 },
                    { 1061, 6, 3.3m, 24 },
                    { 1060, 5, 0.53m, 24 },
                    { 1059, 4, 3.4m, 24 },
                    { 1058, 3, 0.45m, 24 },
                    { 1066, 11, 2.11m, 24 },
                    { 1077, 22, 1275.85m, 24 },
                    { 1078, 23, 1.69m, 24 },
                    { 1079, 24, 0.05m, 24 },
                    { 1098, 43, 8.75m, 24 },
                    { 1097, 42, 9.83m, 24 },
                    { 1096, 41, 4.75m, 24 },
                    { 1095, 40, 4.75m, 24 },
                    { 1094, 39, 0.45m, 24 },
                    { 1093, 38, 0.45m, 24 },
                    { 1092, 37, 0.45m, 24 },
                    { 1091, 36, 1.24m, 24 },
                    { 1090, 35, 1.47m, 24 },
                    { 1089, 34, 25m, 24 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1088, 33, 15m, 24 },
                    { 1087, 32, 55m, 24 },
                    { 1086, 31, 2.1m, 24 },
                    { 1085, 30, 2.45m, 24 },
                    { 1084, 29, 5.26m, 24 },
                    { 1083, 28, 9.28m, 24 },
                    { 1082, 27, 1.55m, 24 },
                    { 1081, 26, 0.1m, 24 },
                    { 1080, 25, 0.1m, 24 },
                    { 1057, 2, 0.25m, 24 },
                    { 1099, 44, 7.92m, 24 },
                    { 1056, 1, 0.3m, 24 },
                    { 1054, 44, 7.92m, 23 },
                    { 1030, 20, 345.8m, 23 },
                    { 1029, 19, 0.95m, 23 },
                    { 1028, 18, 1.05m, 23 },
                    { 1027, 17, 0.5m, 23 },
                    { 1026, 16, 0.53m, 23 },
                    { 1025, 15, 0.48m, 23 },
                    { 1024, 14, 2.94m, 23 },
                    { 1023, 13, 2.68m, 23 },
                    { 1031, 21, 532.58m, 23 },
                    { 1022, 12, 2.75m, 23 },
                    { 1020, 10, 1.62m, 23 },
                    { 1019, 9, 3.25m, 23 },
                    { 1018, 8, 1.1m, 23 },
                    { 1017, 7, 1.45m, 23 },
                    { 1016, 6, 3.3m, 23 },
                    { 1015, 5, 0.53m, 23 },
                    { 1014, 4, 3.4m, 23 },
                    { 1013, 3, 0.45m, 23 },
                    { 1021, 11, 2.11m, 23 },
                    { 1032, 22, 1275.85m, 23 },
                    { 1033, 23, 1.69m, 23 },
                    { 1034, 24, 0.05m, 23 },
                    { 1053, 43, 8.75m, 23 },
                    { 1052, 42, 9.83m, 23 },
                    { 1051, 41, 4.75m, 23 },
                    { 1050, 40, 4.75m, 23 },
                    { 1049, 39, 0.45m, 23 },
                    { 1048, 38, 0.45m, 23 },
                    { 1047, 37, 0.45m, 23 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1046, 36, 1.24m, 23 },
                    { 1045, 35, 1.47m, 23 },
                    { 1044, 34, 25m, 23 },
                    { 1043, 33, 15m, 23 },
                    { 1042, 32, 55m, 23 },
                    { 1041, 31, 2.1m, 23 },
                    { 1040, 30, 2.45m, 23 },
                    { 649, 19, 0.95m, 15 },
                    { 1038, 28, 9.28m, 23 },
                    { 1037, 27, 1.55m, 23 },
                    { 1036, 26, 0.1m, 23 },
                    { 1035, 25, 0.1m, 23 },
                    { 1055, 45, 1.5m, 23 },
                    { 1190, 45, 1.5m, 26 },
                    { 1100, 45, 1.5m, 24 },
                    { 1102, 2, 0.25m, 25 },
                    { 1165, 20, 345.8m, 26 },
                    { 1164, 19, 0.95m, 26 },
                    { 1163, 18, 1.05m, 26 },
                    { 1162, 17, 0.5m, 26 },
                    { 1161, 16, 0.53m, 26 },
                    { 1160, 15, 0.48m, 26 },
                    { 1159, 14, 2.94m, 26 },
                    { 1158, 13, 2.68m, 26 },
                    { 1166, 21, 532.58m, 26 },
                    { 1157, 12, 2.75m, 26 },
                    { 1155, 10, 1.62m, 26 },
                    { 1154, 9, 3.25m, 26 },
                    { 1153, 8, 1.1m, 26 },
                    { 1152, 7, 1.45m, 26 },
                    { 1151, 6, 3.3m, 26 },
                    { 1150, 5, 0.53m, 26 },
                    { 1149, 4, 3.4m, 26 },
                    { 1148, 3, 0.45m, 26 },
                    { 1156, 11, 2.11m, 26 },
                    { 1167, 22, 1275.85m, 26 },
                    { 1168, 23, 1.69m, 26 },
                    { 1169, 24, 0.05m, 26 },
                    { 1188, 43, 8.75m, 26 },
                    { 1187, 42, 9.83m, 26 },
                    { 1186, 41, 4.75m, 26 },
                    { 1185, 40, 4.75m, 26 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1184, 39, 0.45m, 26 },
                    { 1183, 38, 0.45m, 26 },
                    { 1182, 37, 0.45m, 26 },
                    { 1181, 36, 1.24m, 26 },
                    { 1180, 35, 1.47m, 26 },
                    { 1179, 34, 25m, 26 },
                    { 1178, 33, 15m, 26 },
                    { 1177, 32, 55m, 26 },
                    { 1176, 31, 2.1m, 26 },
                    { 1175, 30, 2.45m, 26 },
                    { 1174, 29, 5.26m, 26 },
                    { 1173, 28, 9.28m, 26 },
                    { 1172, 27, 1.55m, 26 },
                    { 1171, 26, 0.1m, 26 },
                    { 1170, 25, 0.1m, 26 },
                    { 1147, 2, 0.25m, 26 },
                    { 1101, 1, 0.3m, 25 },
                    { 1146, 1, 0.3m, 26 },
                    { 1144, 44, 7.92m, 25 },
                    { 1120, 20, 345.8m, 25 },
                    { 1119, 19, 0.95m, 25 },
                    { 1118, 18, 1.05m, 25 },
                    { 1117, 17, 0.5m, 25 },
                    { 1116, 16, 0.53m, 25 },
                    { 1115, 15, 0.48m, 25 },
                    { 1114, 14, 2.94m, 25 },
                    { 1113, 13, 2.68m, 25 },
                    { 1121, 21, 532.58m, 25 },
                    { 1112, 12, 2.75m, 25 },
                    { 1110, 10, 1.62m, 25 },
                    { 1109, 9, 3.25m, 25 },
                    { 1108, 8, 1.1m, 25 },
                    { 1107, 7, 1.45m, 25 },
                    { 1106, 6, 3.3m, 25 },
                    { 1105, 5, 0.53m, 25 },
                    { 1104, 4, 3.4m, 25 },
                    { 1103, 3, 0.45m, 25 },
                    { 1111, 11, 2.11m, 25 },
                    { 1122, 22, 1275.85m, 25 },
                    { 1123, 23, 1.69m, 25 },
                    { 1124, 24, 0.05m, 25 },
                    { 1143, 43, 8.75m, 25 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 1142, 42, 9.83m, 25 },
                    { 1141, 41, 4.75m, 25 },
                    { 1140, 40, 4.75m, 25 },
                    { 1139, 39, 0.45m, 25 },
                    { 1138, 38, 0.45m, 25 },
                    { 1137, 37, 0.45m, 25 },
                    { 1136, 36, 1.24m, 25 },
                    { 1135, 35, 1.47m, 25 },
                    { 1134, 34, 25m, 25 },
                    { 1133, 33, 15m, 25 },
                    { 1132, 32, 55m, 25 },
                    { 1131, 31, 2.1m, 25 },
                    { 1130, 30, 2.45m, 25 },
                    { 1129, 29, 5.26m, 25 },
                    { 1128, 28, 9.28m, 25 },
                    { 1127, 27, 1.55m, 25 },
                    { 1126, 26, 0.1m, 25 },
                    { 1125, 25, 0.1m, 25 },
                    { 1145, 45, 1.5m, 25 },
                    { 648, 18, 1.05m, 15 },
                    { 619, 34, 25m, 14 },
                    { 646, 16, 0.53m, 15 },
                    { 219, 39, 0.45m, 5 },
                    { 218, 38, 0.45m, 5 },
                    { 217, 37, 0.45m, 5 },
                    { 216, 36, 1.24m, 5 },
                    { 215, 35, 1.47m, 5 },
                    { 214, 34, 25m, 5 },
                    { 213, 33, 15m, 5 },
                    { 220, 40, 4.75m, 5 },
                    { 212, 32, 55m, 5 },
                    { 210, 30, 2.45m, 5 },
                    { 209, 29, 5.26m, 5 },
                    { 208, 28, 9.28m, 5 },
                    { 207, 27, 1.55m, 5 },
                    { 206, 26, 0.1m, 5 },
                    { 205, 25, 0.1m, 5 },
                    { 204, 24, 0.05m, 5 },
                    { 211, 31, 2.1m, 5 },
                    { 203, 23, 1.69m, 5 },
                    { 221, 41, 4.75m, 5 },
                    { 223, 43, 8.75m, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 239, 14, 2.94m, 6 },
                    { 238, 13, 2.68m, 6 },
                    { 237, 12, 2.75m, 6 },
                    { 236, 11, 2.11m, 6 },
                    { 235, 10, 1.62m, 6 },
                    { 234, 9, 3.25m, 6 },
                    { 233, 8, 1.1m, 6 },
                    { 222, 42, 9.83m, 5 },
                    { 232, 7, 1.45m, 6 },
                    { 230, 5, 0.53m, 6 },
                    { 229, 4, 3.4m, 6 },
                    { 228, 3, 0.45m, 6 },
                    { 227, 2, 0.25m, 6 },
                    { 226, 1, 0.3m, 6 },
                    { 225, 45, 1.5m, 5 },
                    { 224, 44, 7.92m, 5 },
                    { 231, 6, 3.3m, 6 },
                    { 202, 22, 1275.85m, 5 },
                    { 201, 21, 532.58m, 5 },
                    { 200, 20, 345.8m, 5 },
                    { 178, 43, 8.75m, 4 },
                    { 177, 42, 9.83m, 4 },
                    { 176, 41, 4.75m, 4 },
                    { 175, 40, 4.75m, 4 },
                    { 174, 39, 0.45m, 4 },
                    { 173, 38, 0.45m, 4 },
                    { 172, 37, 0.45m, 4 },
                    { 179, 44, 7.92m, 4 },
                    { 171, 36, 1.24m, 4 },
                    { 169, 34, 25m, 4 },
                    { 168, 33, 15m, 4 },
                    { 167, 32, 55m, 4 },
                    { 166, 31, 2.1m, 4 },
                    { 165, 30, 2.45m, 4 },
                    { 164, 29, 5.26m, 4 },
                    { 163, 28, 9.28m, 4 },
                    { 170, 35, 1.47m, 4 },
                    { 180, 45, 1.5m, 4 },
                    { 181, 1, 0.3m, 5 },
                    { 182, 2, 0.25m, 5 },
                    { 199, 19, 0.95m, 5 },
                    { 198, 18, 1.05m, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 197, 17, 0.5m, 5 },
                    { 196, 16, 0.53m, 5 },
                    { 195, 15, 0.48m, 5 },
                    { 194, 14, 2.94m, 5 },
                    { 193, 13, 2.68m, 5 },
                    { 192, 12, 2.75m, 5 },
                    { 191, 11, 2.11m, 5 },
                    { 190, 10, 1.62m, 5 },
                    { 189, 9, 3.25m, 5 },
                    { 188, 8, 1.1m, 5 },
                    { 187, 7, 1.45m, 5 },
                    { 186, 6, 3.3m, 5 },
                    { 185, 5, 0.53m, 5 },
                    { 184, 4, 3.4m, 5 },
                    { 183, 3, 0.45m, 5 },
                    { 240, 15, 0.48m, 6 },
                    { 162, 27, 1.55m, 4 },
                    { 241, 16, 0.53m, 6 },
                    { 243, 18, 1.05m, 6 },
                    { 300, 30, 2.45m, 7 },
                    { 299, 29, 5.26m, 7 },
                    { 298, 28, 9.28m, 7 },
                    { 297, 27, 1.55m, 7 },
                    { 296, 26, 0.1m, 7 },
                    { 295, 25, 0.1m, 7 },
                    { 294, 24, 0.05m, 7 },
                    { 301, 31, 2.1m, 7 },
                    { 293, 23, 1.69m, 7 },
                    { 291, 21, 532.58m, 7 },
                    { 290, 20, 345.8m, 7 },
                    { 289, 19, 0.95m, 7 },
                    { 647, 17, 0.5m, 15 },
                    { 287, 17, 0.5m, 7 },
                    { 286, 16, 0.53m, 7 },
                    { 285, 15, 0.48m, 7 },
                    { 292, 22, 1275.85m, 7 },
                    { 284, 14, 2.94m, 7 },
                    { 302, 32, 55m, 7 },
                    { 304, 34, 25m, 7 },
                    { 320, 5, 0.53m, 8 },
                    { 319, 4, 3.4m, 8 },
                    { 318, 3, 0.45m, 8 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 317, 2, 0.25m, 8 },
                    { 316, 1, 0.3m, 8 },
                    { 315, 45, 1.5m, 7 },
                    { 314, 44, 7.92m, 7 },
                    { 303, 33, 15m, 7 },
                    { 313, 43, 8.75m, 7 },
                    { 311, 41, 4.75m, 7 },
                    { 310, 40, 4.75m, 7 },
                    { 309, 39, 0.45m, 7 },
                    { 308, 38, 0.45m, 7 },
                    { 307, 37, 0.45m, 7 },
                    { 306, 36, 1.24m, 7 },
                    { 305, 35, 1.47m, 7 },
                    { 312, 42, 9.83m, 7 },
                    { 283, 13, 2.68m, 7 },
                    { 282, 12, 2.75m, 7 },
                    { 281, 11, 2.11m, 7 },
                    { 259, 34, 25m, 6 },
                    { 258, 33, 15m, 6 },
                    { 257, 32, 55m, 6 },
                    { 256, 31, 2.1m, 6 },
                    { 255, 30, 2.45m, 6 },
                    { 254, 29, 5.26m, 6 },
                    { 253, 28, 9.28m, 6 },
                    { 260, 35, 1.47m, 6 },
                    { 252, 27, 1.55m, 6 },
                    { 250, 25, 0.1m, 6 },
                    { 249, 24, 0.05m, 6 },
                    { 248, 23, 1.69m, 6 },
                    { 247, 22, 1275.85m, 6 },
                    { 246, 21, 532.58m, 6 },
                    { 245, 20, 345.8m, 6 },
                    { 244, 19, 0.95m, 6 },
                    { 251, 26, 0.1m, 6 },
                    { 261, 36, 1.24m, 6 },
                    { 262, 37, 0.45m, 6 },
                    { 263, 38, 0.45m, 6 },
                    { 280, 10, 1.62m, 7 },
                    { 279, 9, 3.25m, 7 },
                    { 278, 8, 1.1m, 7 },
                    { 277, 7, 1.45m, 7 },
                    { 276, 6, 3.3m, 7 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 275, 5, 0.53m, 7 },
                    { 274, 4, 3.4m, 7 },
                    { 273, 3, 0.45m, 7 },
                    { 272, 2, 0.25m, 7 },
                    { 271, 1, 0.3m, 7 },
                    { 270, 45, 1.5m, 6 },
                    { 269, 44, 7.92m, 6 },
                    { 268, 43, 8.75m, 6 },
                    { 267, 42, 9.83m, 6 },
                    { 266, 41, 4.75m, 6 },
                    { 265, 40, 4.75m, 6 },
                    { 264, 39, 0.45m, 6 },
                    { 242, 17, 0.5m, 6 },
                    { 321, 6, 3.3m, 8 },
                    { 161, 26, 0.1m, 4 },
                    { 159, 24, 0.05m, 4 },
                    { 57, 12, 2.75m, 2 },
                    { 56, 11, 2.11m, 2 },
                    { 55, 10, 1.62m, 2 },
                    { 54, 9, 3.25m, 2 },
                    { 53, 8, 1.1m, 2 },
                    { 52, 7, 1.45m, 2 },
                    { 51, 6, 3.3m, 2 },
                    { 58, 13, 2.68m, 2 },
                    { 50, 5, 0.53m, 2 },
                    { 48, 3, 0.45m, 2 },
                    { 47, 2, 0.25m, 2 },
                    { 46, 1, 0.3m, 2 },
                    { 45, 45, 1.5m, 1 },
                    { 44, 44, 7.92m, 1 },
                    { 43, 43, 8.75m, 1 },
                    { 42, 42, 9.83m, 1 },
                    { 49, 4, 3.4m, 2 },
                    { 41, 41, 4.75m, 1 },
                    { 59, 14, 2.94m, 2 },
                    { 61, 16, 0.53m, 2 },
                    { 77, 32, 55m, 2 },
                    { 76, 31, 2.1m, 2 },
                    { 75, 30, 2.45m, 2 },
                    { 74, 29, 5.26m, 2 },
                    { 73, 28, 9.28m, 2 },
                    { 72, 27, 1.55m, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 71, 26, 0.1m, 2 },
                    { 60, 15, 0.48m, 2 },
                    { 70, 25, 0.1m, 2 },
                    { 68, 23, 1.69m, 2 },
                    { 67, 22, 1275.85m, 2 },
                    { 66, 21, 532.58m, 2 },
                    { 65, 20, 345.8m, 2 },
                    { 64, 19, 0.95m, 2 },
                    { 63, 18, 1.05m, 2 },
                    { 62, 17, 0.5m, 2 },
                    { 69, 24, 0.05m, 2 },
                    { 40, 40, 4.75m, 1 },
                    { 39, 39, 0.45m, 1 },
                    { 38, 38, 0.45m, 1 },
                    { 16, 16, 0.53m, 1 },
                    { 15, 15, 0.48m, 1 },
                    { 14, 14, 2.94m, 1 },
                    { 13, 13, 2.68m, 1 },
                    { 12, 12, 2.75m, 1 },
                    { 11, 11, 2.11m, 1 },
                    { 10, 10, 1.62m, 1 },
                    { 17, 17, 0.5m, 1 },
                    { 9, 9, 3.25m, 1 },
                    { 7, 7, 1.45m, 1 },
                    { 6, 6, 3.3m, 1 },
                    { 5, 5, 0.53m, 1 },
                    { 4, 4, 3.4m, 1 },
                    { 3, 3, 0.45m, 1 },
                    { 2, 2, 0.25m, 1 },
                    { 1, 1, 0.3m, 1 },
                    { 8, 8, 1.1m, 1 },
                    { 18, 18, 1.05m, 1 },
                    { 19, 19, 0.95m, 1 },
                    { 20, 20, 345.8m, 1 },
                    { 37, 37, 0.45m, 1 },
                    { 36, 36, 1.24m, 1 },
                    { 35, 35, 1.47m, 1 },
                    { 34, 34, 25m, 1 },
                    { 33, 33, 15m, 1 },
                    { 32, 32, 55m, 1 },
                    { 31, 31, 2.1m, 1 },
                    { 30, 30, 2.45m, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 29, 29, 5.26m, 1 },
                    { 28, 28, 9.28m, 1 },
                    { 27, 27, 1.55m, 1 },
                    { 26, 26, 0.1m, 1 },
                    { 25, 25, 0.1m, 1 },
                    { 24, 24, 0.05m, 1 },
                    { 23, 23, 1.69m, 1 },
                    { 22, 22, 1275.85m, 1 },
                    { 21, 21, 532.58m, 1 },
                    { 78, 33, 15m, 2 },
                    { 160, 25, 0.1m, 4 },
                    { 79, 34, 25m, 2 },
                    { 81, 36, 1.24m, 2 },
                    { 138, 3, 0.45m, 4 },
                    { 137, 2, 0.25m, 4 },
                    { 136, 1, 0.3m, 4 },
                    { 135, 45, 1.5m, 3 },
                    { 134, 44, 7.92m, 3 },
                    { 133, 43, 8.75m, 3 },
                    { 132, 42, 9.83m, 3 },
                    { 139, 4, 3.4m, 4 },
                    { 131, 41, 4.75m, 3 },
                    { 129, 39, 0.45m, 3 },
                    { 128, 38, 0.45m, 3 },
                    { 127, 37, 0.45m, 3 },
                    { 126, 36, 1.24m, 3 },
                    { 125, 35, 1.47m, 3 },
                    { 124, 34, 25m, 3 },
                    { 123, 33, 15m, 3 },
                    { 130, 40, 4.75m, 3 },
                    { 122, 32, 55m, 3 },
                    { 140, 5, 0.53m, 4 },
                    { 142, 7, 1.45m, 4 },
                    { 158, 23, 1.69m, 4 },
                    { 157, 22, 1275.85m, 4 },
                    { 156, 21, 532.58m, 4 },
                    { 155, 20, 345.8m, 4 },
                    { 154, 19, 0.95m, 4 },
                    { 153, 18, 1.05m, 4 },
                    { 152, 17, 0.5m, 4 },
                    { 141, 6, 3.3m, 4 },
                    { 151, 16, 0.53m, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 149, 14, 2.94m, 4 },
                    { 148, 13, 2.68m, 4 },
                    { 147, 12, 2.75m, 4 },
                    { 146, 11, 2.11m, 4 },
                    { 145, 10, 1.62m, 4 },
                    { 144, 9, 3.25m, 4 },
                    { 143, 8, 1.1m, 4 },
                    { 150, 15, 0.48m, 4 },
                    { 121, 31, 2.1m, 3 },
                    { 120, 30, 2.45m, 3 },
                    { 119, 29, 5.26m, 3 },
                    { 97, 7, 1.45m, 3 },
                    { 96, 6, 3.3m, 3 },
                    { 95, 5, 0.53m, 3 },
                    { 94, 4, 3.4m, 3 },
                    { 93, 3, 0.45m, 3 },
                    { 92, 2, 0.25m, 3 },
                    { 91, 1, 0.3m, 3 },
                    { 98, 8, 1.1m, 3 },
                    { 90, 45, 1.5m, 2 },
                    { 88, 43, 8.75m, 2 },
                    { 87, 42, 9.83m, 2 },
                    { 86, 41, 4.75m, 2 },
                    { 85, 40, 4.75m, 2 },
                    { 84, 39, 0.45m, 2 },
                    { 83, 38, 0.45m, 2 },
                    { 82, 37, 0.45m, 2 },
                    { 89, 44, 7.92m, 2 },
                    { 99, 9, 3.25m, 3 },
                    { 100, 10, 1.62m, 3 },
                    { 101, 11, 2.11m, 3 },
                    { 118, 28, 9.28m, 3 },
                    { 117, 27, 1.55m, 3 },
                    { 116, 26, 0.1m, 3 },
                    { 115, 25, 0.1m, 3 },
                    { 114, 24, 0.05m, 3 },
                    { 113, 23, 1.69m, 3 },
                    { 112, 22, 1275.85m, 3 },
                    { 111, 21, 532.58m, 3 },
                    { 110, 20, 345.8m, 3 },
                    { 109, 19, 0.95m, 3 },
                    { 108, 18, 1.05m, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 107, 17, 0.5m, 3 },
                    { 106, 16, 0.53m, 3 },
                    { 105, 15, 0.48m, 3 },
                    { 104, 14, 2.94m, 3 },
                    { 103, 13, 2.68m, 3 },
                    { 102, 12, 2.75m, 3 },
                    { 80, 35, 1.47m, 2 },
                    { 322, 7, 1.45m, 8 },
                    { 288, 18, 1.05m, 7 },
                    { 324, 9, 3.25m, 8 },
                    { 544, 4, 3.4m, 13 },
                    { 543, 3, 0.45m, 13 },
                    { 542, 2, 0.25m, 13 },
                    { 541, 1, 0.3m, 13 },
                    { 540, 45, 1.5m, 12 },
                    { 539, 44, 7.92m, 12 },
                    { 538, 43, 8.75m, 12 },
                    { 545, 5, 0.53m, 13 },
                    { 537, 42, 9.83m, 12 },
                    { 535, 40, 4.75m, 12 },
                    { 534, 39, 0.45m, 12 },
                    { 533, 38, 0.45m, 12 },
                    { 532, 37, 0.45m, 12 },
                    { 531, 36, 1.24m, 12 },
                    { 530, 35, 1.47m, 12 },
                    { 529, 34, 25m, 12 },
                    { 536, 41, 4.75m, 12 },
                    { 528, 33, 15m, 12 },
                    { 546, 6, 3.3m, 13 },
                    { 548, 8, 1.1m, 13 },
                    { 564, 24, 0.05m, 13 },
                    { 563, 23, 1.69m, 13 },
                    { 562, 22, 1275.85m, 13 },
                    { 561, 21, 532.58m, 13 },
                    { 560, 20, 345.8m, 13 },
                    { 559, 19, 0.95m, 13 },
                    { 558, 18, 1.05m, 13 },
                    { 547, 7, 1.45m, 13 },
                    { 557, 17, 0.5m, 13 },
                    { 555, 15, 0.48m, 13 },
                    { 554, 14, 2.94m, 13 },
                    { 553, 13, 2.68m, 13 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 552, 12, 2.75m, 13 },
                    { 551, 11, 2.11m, 13 },
                    { 550, 10, 1.62m, 13 },
                    { 549, 9, 3.25m, 13 },
                    { 556, 16, 0.53m, 13 },
                    { 527, 32, 55m, 12 },
                    { 526, 31, 2.1m, 12 },
                    { 525, 30, 2.45m, 12 },
                    { 503, 8, 1.1m, 12 },
                    { 502, 7, 1.45m, 12 },
                    { 501, 6, 3.3m, 12 },
                    { 500, 5, 0.53m, 12 },
                    { 499, 4, 3.4m, 12 },
                    { 498, 3, 0.45m, 12 },
                    { 497, 2, 0.25m, 12 },
                    { 504, 9, 3.25m, 12 },
                    { 496, 1, 0.3m, 12 },
                    { 494, 44, 7.92m, 11 },
                    { 493, 43, 8.75m, 11 },
                    { 492, 42, 9.83m, 11 },
                    { 491, 41, 4.75m, 11 },
                    { 490, 40, 4.75m, 11 },
                    { 489, 39, 0.45m, 11 },
                    { 488, 38, 0.45m, 11 },
                    { 495, 45, 1.5m, 11 },
                    { 505, 10, 1.62m, 12 },
                    { 506, 11, 2.11m, 12 },
                    { 507, 12, 2.75m, 12 },
                    { 524, 29, 5.26m, 12 },
                    { 523, 28, 9.28m, 12 },
                    { 522, 27, 1.55m, 12 },
                    { 521, 26, 0.1m, 12 },
                    { 323, 8, 1.1m, 8 },
                    { 519, 24, 0.05m, 12 },
                    { 518, 23, 1.69m, 12 },
                    { 517, 22, 1275.85m, 12 },
                    { 516, 21, 532.58m, 12 },
                    { 515, 20, 345.8m, 12 },
                    { 514, 19, 0.95m, 12 },
                    { 513, 18, 1.05m, 12 },
                    { 512, 17, 0.5m, 12 },
                    { 511, 16, 0.53m, 12 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 510, 15, 0.48m, 12 },
                    { 509, 14, 2.94m, 12 },
                    { 508, 13, 2.68m, 12 },
                    { 565, 25, 0.1m, 13 },
                    { 487, 37, 0.45m, 11 },
                    { 566, 26, 0.1m, 13 },
                    { 568, 28, 9.28m, 13 },
                    { 625, 40, 4.75m, 14 },
                    { 624, 39, 0.45m, 14 },
                    { 623, 38, 0.45m, 14 },
                    { 622, 37, 0.45m, 14 },
                    { 621, 36, 1.24m, 14 },
                    { 620, 35, 1.47m, 14 },
                    { 1369, 44, 7.92m, 30 },
                    { 626, 41, 4.75m, 14 },
                    { 618, 33, 15m, 14 },
                    { 616, 31, 2.1m, 14 },
                    { 615, 30, 2.45m, 14 },
                    { 614, 29, 5.26m, 14 },
                    { 613, 28, 9.28m, 14 },
                    { 612, 27, 1.55m, 14 },
                    { 611, 26, 0.1m, 14 },
                    { 610, 25, 0.1m, 14 },
                    { 617, 32, 55m, 14 },
                    { 609, 24, 0.05m, 14 },
                    { 627, 42, 9.83m, 14 },
                    { 629, 44, 7.92m, 14 },
                    { 645, 15, 0.48m, 15 },
                    { 644, 14, 2.94m, 15 },
                    { 643, 13, 2.68m, 15 },
                    { 642, 12, 2.75m, 15 },
                    { 641, 11, 2.11m, 15 },
                    { 640, 10, 1.62m, 15 },
                    { 639, 9, 3.25m, 15 },
                    { 628, 43, 8.75m, 14 },
                    { 638, 8, 1.1m, 15 },
                    { 636, 6, 3.3m, 15 },
                    { 635, 5, 0.53m, 15 },
                    { 634, 4, 3.4m, 15 },
                    { 633, 3, 0.45m, 15 },
                    { 632, 2, 0.25m, 15 },
                    { 631, 1, 0.3m, 15 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 630, 45, 1.5m, 14 },
                    { 637, 7, 1.45m, 15 },
                    { 608, 23, 1.69m, 14 },
                    { 607, 22, 1275.85m, 14 },
                    { 606, 21, 532.58m, 14 },
                    { 584, 44, 7.92m, 13 },
                    { 583, 43, 8.75m, 13 },
                    { 582, 42, 9.83m, 13 },
                    { 581, 41, 4.75m, 13 },
                    { 580, 40, 4.75m, 13 },
                    { 579, 39, 0.45m, 13 },
                    { 578, 38, 0.45m, 13 },
                    { 585, 45, 1.5m, 13 },
                    { 577, 37, 0.45m, 13 },
                    { 575, 35, 1.47m, 13 },
                    { 574, 34, 25m, 13 },
                    { 573, 33, 15m, 13 },
                    { 572, 32, 55m, 13 },
                    { 571, 31, 2.1m, 13 },
                    { 570, 30, 2.45m, 13 },
                    { 569, 29, 5.26m, 13 },
                    { 576, 36, 1.24m, 13 },
                    { 586, 1, 0.3m, 14 },
                    { 587, 2, 0.25m, 14 },
                    { 588, 3, 0.45m, 14 },
                    { 605, 20, 345.8m, 14 },
                    { 604, 19, 0.95m, 14 },
                    { 603, 18, 1.05m, 14 },
                    { 602, 17, 0.5m, 14 },
                    { 601, 16, 0.53m, 14 },
                    { 600, 15, 0.48m, 14 },
                    { 599, 14, 2.94m, 14 },
                    { 598, 13, 2.68m, 14 },
                    { 597, 12, 2.75m, 14 },
                    { 596, 11, 2.11m, 14 },
                    { 595, 10, 1.62m, 14 },
                    { 594, 9, 3.25m, 14 },
                    { 593, 8, 1.1m, 14 },
                    { 592, 7, 1.45m, 14 },
                    { 591, 6, 3.3m, 14 },
                    { 590, 5, 0.53m, 14 },
                    { 589, 4, 3.4m, 14 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 567, 27, 1.55m, 13 },
                    { 486, 36, 1.24m, 11 },
                    { 520, 25, 0.1m, 12 },
                    { 484, 34, 25m, 11 },
                    { 381, 21, 532.58m, 9 },
                    { 380, 20, 345.8m, 9 },
                    { 379, 19, 0.95m, 9 },
                    { 378, 18, 1.05m, 9 },
                    { 377, 17, 0.5m, 9 },
                    { 376, 16, 0.53m, 9 },
                    { 375, 15, 0.48m, 9 },
                    { 382, 22, 1275.85m, 9 },
                    { 374, 14, 2.94m, 9 },
                    { 372, 12, 2.75m, 9 },
                    { 371, 11, 2.11m, 9 },
                    { 370, 10, 1.62m, 9 },
                    { 485, 35, 1.47m, 11 },
                    { 368, 8, 1.1m, 9 },
                    { 367, 7, 1.45m, 9 },
                    { 366, 6, 3.3m, 9 },
                    { 373, 13, 2.68m, 9 },
                    { 365, 5, 0.53m, 9 },
                    { 383, 23, 1.69m, 9 },
                    { 385, 25, 0.1m, 9 },
                    { 401, 41, 4.75m, 9 },
                    { 400, 40, 4.75m, 9 },
                    { 399, 39, 0.45m, 9 },
                    { 398, 38, 0.45m, 9 },
                    { 397, 37, 0.45m, 9 },
                    { 396, 36, 1.24m, 9 },
                    { 395, 35, 1.47m, 9 },
                    { 384, 24, 0.05m, 9 },
                    { 394, 34, 25m, 9 },
                    { 392, 32, 55m, 9 },
                    { 391, 31, 2.1m, 9 },
                    { 390, 30, 2.45m, 9 },
                    { 389, 29, 5.26m, 9 },
                    { 388, 28, 9.28m, 9 },
                    { 387, 27, 1.55m, 9 },
                    { 386, 26, 0.1m, 9 },
                    { 393, 33, 15m, 9 },
                    { 364, 4, 3.4m, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 363, 3, 0.45m, 9 },
                    { 362, 2, 0.25m, 9 },
                    { 340, 25, 0.1m, 8 },
                    { 339, 24, 0.05m, 8 },
                    { 338, 23, 1.69m, 8 },
                    { 337, 22, 1275.85m, 8 },
                    { 336, 21, 532.58m, 8 },
                    { 335, 20, 345.8m, 8 },
                    { 334, 19, 0.95m, 8 },
                    { 341, 26, 0.1m, 8 },
                    { 333, 18, 1.05m, 8 },
                    { 331, 16, 0.53m, 8 },
                    { 330, 15, 0.48m, 8 },
                    { 329, 14, 2.94m, 8 },
                    { 328, 13, 2.68m, 8 },
                    { 327, 12, 2.75m, 8 },
                    { 326, 11, 2.11m, 8 },
                    { 325, 10, 1.62m, 8 },
                    { 332, 17, 0.5m, 8 },
                    { 342, 27, 1.55m, 8 },
                    { 343, 28, 9.28m, 8 },
                    { 344, 29, 5.26m, 8 },
                    { 361, 1, 0.3m, 9 },
                    { 360, 45, 1.5m, 8 },
                    { 359, 44, 7.92m, 8 },
                    { 358, 43, 8.75m, 8 },
                    { 357, 42, 9.83m, 8 },
                    { 356, 41, 4.75m, 8 },
                    { 355, 40, 4.75m, 8 },
                    { 354, 39, 0.45m, 8 },
                    { 353, 38, 0.45m, 8 },
                    { 352, 37, 0.45m, 8 },
                    { 351, 36, 1.24m, 8 },
                    { 350, 35, 1.47m, 8 },
                    { 349, 34, 25m, 8 },
                    { 348, 33, 15m, 8 },
                    { 347, 32, 55m, 8 },
                    { 346, 31, 2.1m, 8 },
                    { 345, 30, 2.45m, 8 },
                    { 402, 42, 9.83m, 9 },
                    { 403, 43, 8.75m, 9 },
                    { 369, 9, 3.25m, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 405, 45, 1.5m, 9 },
                    { 462, 12, 2.75m, 11 },
                    { 461, 11, 2.11m, 11 },
                    { 460, 10, 1.62m, 11 },
                    { 459, 9, 3.25m, 11 },
                    { 458, 8, 1.1m, 11 },
                    { 457, 7, 1.45m, 11 },
                    { 456, 6, 3.3m, 11 },
                    { 463, 13, 2.68m, 11 },
                    { 455, 5, 0.53m, 11 },
                    { 453, 3, 0.45m, 11 },
                    { 452, 2, 0.25m, 11 },
                    { 451, 1, 0.3m, 11 },
                    { 450, 45, 1.5m, 10 },
                    { 449, 44, 7.92m, 10 },
                    { 448, 43, 8.75m, 10 },
                    { 447, 42, 9.83m, 10 },
                    { 454, 4, 3.4m, 11 },
                    { 464, 14, 2.94m, 11 },
                    { 465, 15, 0.48m, 11 },
                    { 466, 16, 0.53m, 11 },
                    { 483, 33, 15m, 11 },
                    { 482, 32, 55m, 11 },
                    { 481, 31, 2.1m, 11 },
                    { 480, 30, 2.45m, 11 },
                    { 404, 44, 7.92m, 9 },
                    { 478, 28, 9.28m, 11 },
                    { 477, 27, 1.55m, 11 },
                    { 476, 26, 0.1m, 11 },
                    { 475, 25, 0.1m, 11 },
                    { 474, 24, 0.05m, 11 },
                    { 473, 23, 1.69m, 11 },
                    { 472, 22, 1275.85m, 11 },
                    { 471, 21, 532.58m, 11 },
                    { 470, 20, 345.8m, 11 },
                    { 469, 19, 0.95m, 11 },
                    { 468, 18, 1.05m, 11 },
                    { 467, 17, 0.5m, 11 },
                    { 446, 41, 4.75m, 10 },
                    { 445, 40, 4.75m, 10 },
                    { 479, 29, 5.26m, 11 },
                    { 443, 38, 0.45m, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[,]
                {
                    { 421, 16, 0.53m, 10 },
                    { 420, 15, 0.48m, 10 },
                    { 419, 14, 2.94m, 10 },
                    { 418, 13, 2.68m, 10 },
                    { 417, 12, 2.75m, 10 },
                    { 416, 11, 2.11m, 10 },
                    { 415, 10, 1.62m, 10 },
                    { 414, 9, 3.25m, 10 },
                    { 413, 8, 1.1m, 10 },
                    { 412, 7, 1.45m, 10 },
                    { 411, 6, 3.3m, 10 },
                    { 410, 5, 0.53m, 10 },
                    { 409, 4, 3.4m, 10 },
                    { 408, 3, 0.45m, 10 },
                    { 407, 2, 0.25m, 10 },
                    { 406, 1, 0.3m, 10 },
                    { 444, 39, 0.45m, 10 },
                    { 422, 17, 0.5m, 10 },
                    { 423, 18, 1.05m, 10 },
                    { 1370, 45, 1.5m, 30 },
                    { 425, 20, 345.8m, 10 },
                    { 424, 19, 0.95m, 10 },
                    { 440, 35, 1.47m, 10 },
                    { 439, 34, 25m, 10 },
                    { 438, 33, 15m, 10 },
                    { 437, 32, 55m, 10 },
                    { 436, 31, 2.1m, 10 },
                    { 435, 30, 2.45m, 10 },
                    { 434, 29, 5.26m, 10 },
                    { 441, 36, 1.24m, 10 },
                    { 432, 27, 1.55m, 10 },
                    { 426, 21, 532.58m, 10 },
                    { 433, 28, 9.28m, 10 },
                    { 427, 22, 1275.85m, 10 },
                    { 442, 37, 0.45m, 10 },
                    { 429, 24, 0.05m, 10 },
                    { 430, 25, 0.1m, 10 },
                    { 431, 26, 0.1m, 10 },
                    { 428, 23, 1.69m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { 18, "Palermo - Buenos Aires, Argentina", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(2), "Sucursal Alto Palermo", 6 },
                    { 19, "Castelar - Morón - Buenos Aires, Argentina", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(3), "Sucursal Plaza Oeste", 6 },
                    { 20, "Boulogne - Buenos Aires, Argentina", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(5), "Sucursal Soleil Factory", 6 }
                });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { 21, "Rosario, Argentina", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(7), "Sucursal Portal Rosario", 6 },
                    { 22, "Caracas, Venezuela", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(8), "Sucursal Centro Sambil", 7 },
                    { 23, "Valencia, Venezuela", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(10), "Sucursal Matrópolis Valencia", 7 },
                    { 25, "San Juan, Puerto Rico", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(13), "Sucursal The Mall of San Juan", 8 },
                    { 26, "Guaynabo, Puerto Rico", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(14), "Sucursal San Patricio Plaza", 8 },
                    { 28, "Talcahuano - AM Concepción, Chile", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(18), "Sucursal Mall Plaza Trébol", 9 },
                    { 29, "Bogotá, Colombia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(20), "Sucursal Unicentroi Bogotá", 10 },
                    { 30, "Medellín, Colombia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(21), "Sucursal El Tesoro", 10 },
                    { 31, "Vía Centenario, Panamá", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(23), "Sucursal AltaPlaza Mall", 11 },
                    { 17, "Buenos Aires, Argentina", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local), "Sucursal Unicenter", 6 },
                    { 24, "San Juán, Puerto Rico", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(11), "Sucursal Plaza Las Américas", 8 },
                    { 27, "Las condes - RM Santiago, Chile", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(16), "Sucursal Alto Las Condes", 9 },
                    { 9, "C. 55, Florencia, San José, San Vicente, Costa Rica", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9987), "Sucursal Lincoln Plaza", 3 },
                    { 15, "Benito Juárez - México DF, México", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9997), "Sucursal Plaza Universidad", 5 },
                    { 1, "Metrocentro 8va etapa, El Salvador", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(1709), "Sucursal Metrocentro", 1 },
                    { 2, "CC Galerías, paseo Gral Escalón, El Salvador", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9963), "Sucursal Galerías", 1 },
                    { 3, "Antiguo Cuscatlán - La Libertad, El Salvador", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9977), "Sucursal Multiplaza", 1 },
                    { 4, "Calle 23 10-00 zona 4 de Mixco Condado Naranjo, Guatemala", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9979), "Sucursal Naranjo Mall", 2 },
                    { 5, "Zona Viva, cuarta avenida 12-44, Guatemala", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9981), "Sucursal FontaBella", 2 },
                    { 6, "Diagonal 6 13-01, Guatemala", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9982), "Sucursal Oakland", 2 },
                    { 16, "Interlomas - Huixquilucan, México", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9999), "Sucursal Paseo Interlomas", 5 },
                    { 7, "Zona 10, calle 16 2.00, Guatemala", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9984), "Sucursal Los Próceres", 2 },
                    { 32, "XCCW+5R6, Marginal, Avenida Roosevelt, Panamá", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(25), "Sucursal Albrook Mall", 11 },
                    { 10, "diagonal a Forum, Radial Sta. Ana - San Rafael - Belén 2 Lindora, San José, Pozos, Costa Rica", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9989), "Sucursal Terrazas Lindora", 3 },
                    { 11, "El Hogar, San José, Curridabat, 11801, Costa Rica", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9991), "Sucursal Multiplaza Curridabat", 3 },
                    { 12, "Rio de Janeiro, Brasil", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9992), "Sucursal Village Mall", 4 },
                    { 13, "Sao Paulo, Brasil", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9994), "Sucursal Cidade Jardim", 4 },
                    { 14, "Ciudad de Mexico, México", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9996), "Sucursal Centro Santa Fe", 5 },
                    { 8, "Autop. Próspero Fernández, San José, Escazú, Costa Rica", new DateTime(2022, 5, 16, 16, 54, 19, 730, DateTimeKind.Local).AddTicks(9986), "Sucursal Multiplaza Escazú", 3 },
                    { 33, "Vía Israel, Panamá", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(26), "Sucursal Multiplaza Panamá", 11 },
                    { 43, "esquina Carretera de Juanillo, Blvd. Turístico del Este, Punta Cana 23000, República Dominicana", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(42), "Sucursal BlueMall Puntacana", 16 },
                    { 35, "Ruta Gral. Líber Seregni km22.5, 15000 Ciudad de la Costa, Departamento de Canelones, Uruguay", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(29), "Sucursal Almenara Mall", 12 },
                    { 56, "Av. Dom João II 40, 1990-094 Lisboa, Portugal", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(62), "Sucursal Vasco da Gama", 24 },
                    { 57, "Av. Cruzeiro Seixas 5 e 7, 2650-505 Amadora, Portugal", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(64), "Sucursal Dolce Vita Tejo", 24 },
                    { 58, "Bernard St, London WC1N 1BS, Reino Unido", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(66), "Sucursal The Brunswick Center", 25 },
                    { 59, "Stable St, London N1C 4DQ, Reino Unido", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(67), "Sucursal Coral Drops Yard", 25 },
                    { 60, "St Stephen's Green, Dublin, D02 HX65, Irlanda", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(69), "Sucursal Stephen's Green", 26 },
                    { 61, "1 Talbot St, North City, Dublin, D01 XW65, Irlanda", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(70), "Sucursal Talbot Mall", 26 },
                    { 55, "2 All. Emile Zola, 31700 Blagnac, Francia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(61), "Sucursal Blagnac", 23 },
                    { 62, "Am Einkaufszentrum 1, 44791 Bochum, Alemania", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(72), "Sucursal Ruhr Park", 27 },
                    { 64, "Via Giuseppe Eugenio Luraghi, 11, 20044 Arese MI, Italia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(75), "Sucursal Il Centro", 28 },
                    { 65, "Via alla Fiumara, 15/16, 16149 Genova GE, Italia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(77), "Sucursal La Fiumara", 28 }
                });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { 66, "Sofikli Venizelou, Minoos & Pelasgon Σοφοκλή Bενιζέλου, Μίνωος &, Pelasgon, Iraklio 713 03, Grecia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(78), "Sucursal Talos Plaza", 29 },
                    { 67, "Agiou Dimitriou 19, Athina 105 54, Grecia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(80), "Sucursal 3Quarters", 29 },
                    { 68, "Bd Lambermont 1, 1000 Bruxelles, Bélgica", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(81), "Sucursal Docks Bruxsel", 30 },
                    { 69, "Pl. de l'Accueil 10, 1348 Ottignies-Louvain-la-Neuve, Bélgica", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(83), "Sucursal L'esplanade", 30 },
                    { 63, "Ob. Bürger 127, 27568 Bremerhaven, Alemania", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(73), "Sucursal Columbus Center", 27 },
                    { 34, "v. Luis Alberto de Herrera 3365, 11600 Montevideo, Departamento de Montevideo, Uruguay", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(28), "Sucursal Nuevocentro Shopping", 12 },
                    { 54, "15 Parvis De La Défense, 92092 Puteaux, Francia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(59), "Sucursal Les Quatre Temps", 23 },
                    { 51, "Amraser-See-Straße 56a, 6020 Innsbruck, Austria", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(55), "Sucursal DEZ Innsbruck", 21 },
                    { 36, "Avenida Naciones Unidas entre, Av. 6 de Diciembre, Quito, Ecuador", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(31), "Sucursal Quicentro Shopping", 13 },
                    { 37, "4º Pasaje 1 NE, Guayaquil 090513, Ecuador", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(33), "Sucursal Mall del Sol", 13 },
                    { 38, "Santiago de Surco - Lima, Perú", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(34), "Sucursal Jockey Plaza", 14 },
                    { 39, "San Miguel - Lima, Perú", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(36), "Sucursal Plaza San Miguel", 14 },
                    { 40, "Av. Sta. Teresa 1827, Asunción, Paraguay", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(37), "Sucursal Paseo La Galería", 15 },
                    { 41, "F9PV+PG6, Avenida Doctor Luis Maria Argaña, Cd. del Este, Paraguay", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(39), "Sucursal Shopping Paris", 15 },
                    { 52, "Stjärntorget 13 C, 169 79 Solna, Suecia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(56), "Sucursal Mall of Scandinaviaultiplaza Curridabat", 22 },
                    { 42, "Corner of, P.º de los Aviadores, Santo Domingo 10413, República Dominicana", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(40), "Sucursal Sambil Santo Domingo", 16 },
                    { 45, "Semaforos de Villa Progreso 1 cuadra al Oeste, Nicaragua", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(45), "Sucursal Multicentro Las Américas", 18 },
                    { 46, "Av. de Gran Bretaña, s/n, 28916 Leganés, Madrid, España", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(47), "Sucursal Centro Comercial Parquesur", 19 },
                    { 47, "Ctra. Ajalvir Centro Comerci, s/n, 28850 Torrejón de Ardoz, Madrid, España", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(48), "Sucursal Centro Comercial Parque Corredor", 19 },
                    { 48, "Kiyevsky Station Square, 2, Moscow, Rusia, 121059", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(50), "Sucursal Evropeysky", 20 },
                    { 49, "Novoryazanskoye Shosse, 8, Kotelniki, Moscow Oblast, Rusia, 140053", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(51), "Sucursal Outlet Village Belaya Dacha", 20 },
                    { 50, "Vösendorfer Südring, 2334 Vösendorf, Austria", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(53), "Sucursal Westfield Shopping City Süd", 21 },
                    { 44, "1Calle ,Frente A Farmacia Kielsa ,Carretera a San Pedro SULA, Tegucigalpa, Honduras", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(44), "Sucursal City Mall", 17 },
                    { 53, "Stora Marknadsvägen 15, 183 70 Täby, Suecia", new DateTime(2022, 5, 16, 16, 54, 19, 731, DateTimeKind.Local).AddTicks(58), "Sucursal Centro de Täby", 22 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[,]
                {
                    { 1, "usuario_admin@wendy.com", "admin", new byte[] { 123, 221, 62, 86, 10, 33, 58, 211, 138, 186, 150, 13, 115, 248, 202, 163, 182, 248, 246, 29, 164, 61, 5, 133, 223, 119, 142, 49, 26, 158, 124, 179, 30, 81, 248, 223, 82, 69, 212, 81, 117, 33, 233, 133, 101, 196, 83, 17, 142, 237, 237, 157, 206, 144, 207, 202, 72, 165, 196, 193, 86, 97, 71, 253 }, new byte[] { 42, 229, 201, 96, 119, 79, 30, 249, 234, 6, 39, 65, 162, 27, 36, 224, 150, 112, 89, 185, 7, 214, 42, 174, 102, 7, 137, 119, 81, 54, 154, 179, 156, 47, 159, 112, 93, 162, 27, 228, 85, 148, 73, 154, 79, 28, 108, 228, 230, 145, 83, 233, 72, 242, 20, 76, 210, 64, 253, 118, 172, 197, 190, 125, 212, 191, 9, 169, 185, 34, 162, 82, 87, 164, 11, 101, 152, 154, 186, 98, 187, 185, 224, 54, 172, 202, 171, 177, 66, 148, 211, 137, 251, 210, 106, 32, 98, 69, 253, 94, 147, 223, 138, 122, 255, 58, 221, 106, 4, 52, 129, 228, 86, 37, 255, 52, 164, 139, 42, 250, 26, 5, 236, 109, 205, 161, 194, 134 }, "ADMIN", 1 },
                    { 2, "carlos_molina@wendy.com", "carmolina", new byte[] { 123, 221, 62, 86, 10, 33, 58, 211, 138, 186, 150, 13, 115, 248, 202, 163, 182, 248, 246, 29, 164, 61, 5, 133, 223, 119, 142, 49, 26, 158, 124, 179, 30, 81, 248, 223, 82, 69, 212, 81, 117, 33, 233, 133, 101, 196, 83, 17, 142, 237, 237, 157, 206, 144, 207, 202, 72, 165, 196, 193, 86, 97, 71, 253 }, new byte[] { 42, 229, 201, 96, 119, 79, 30, 249, 234, 6, 39, 65, 162, 27, 36, 224, 150, 112, 89, 185, 7, 214, 42, 174, 102, 7, 137, 119, 81, 54, 154, 179, 156, 47, 159, 112, 93, 162, 27, 228, 85, 148, 73, 154, 79, 28, 108, 228, 230, 145, 83, 233, 72, 242, 20, 76, 210, 64, 253, 118, 172, 197, 190, 125, 212, 191, 9, 169, 185, 34, 162, 82, 87, 164, 11, 101, 152, 154, 186, 98, 187, 185, 224, 54, 172, 202, 171, 177, 66, 148, 211, 137, 251, 210, 106, 32, 98, 69, 253, 94, 147, 223, 138, 122, 255, 58, 221, 106, 4, 52, 129, 228, 86, 37, 255, 52, 164, 139, 42, 250, 26, 5, 236, 109, 205, 161, 194, 134 }, "SUPERVISOR", 1 },
                    { 3, "sa18004@ues.edu.sv", "erisaravia", new byte[] { 123, 221, 62, 86, 10, 33, 58, 211, 138, 186, 150, 13, 115, 248, 202, 163, 182, 248, 246, 29, 164, 61, 5, 133, 223, 119, 142, 49, 26, 158, 124, 179, 30, 81, 248, 223, 82, 69, 212, 81, 117, 33, 233, 133, 101, 196, 83, 17, 142, 237, 237, 157, 206, 144, 207, 202, 72, 165, 196, 193, 86, 97, 71, 253 }, new byte[] { 42, 229, 201, 96, 119, 79, 30, 249, 234, 6, 39, 65, 162, 27, 36, 224, 150, 112, 89, 185, 7, 214, 42, 174, 102, 7, 137, 119, 81, 54, 154, 179, 156, 47, 159, 112, 93, 162, 27, 228, 85, 148, 73, 154, 79, 28, 108, 228, 230, 145, 83, 233, 72, 242, 20, 76, 210, 64, 253, 118, 172, 197, 190, 125, 212, 191, 9, 169, 185, 34, 162, 82, 87, 164, 11, 101, 152, 154, 186, 98, 187, 185, 224, 54, 172, 202, 171, 177, 66, 148, 211, 137, 251, 210, 106, 32, 98, 69, 253, 94, 147, 223, 138, 122, 255, 58, 221, 106, 4, 52, 129, 228, 86, 37, 255, 52, 164, 139, 42, 250, 26, 5, 236, 109, 205, 161, 194, 134 }, "SUPERVISOR", 2 },
                    { 4, "gh06007@ues.edu.sv", "eligarcia", new byte[] { 123, 221, 62, 86, 10, 33, 58, 211, 138, 186, 150, 13, 115, 248, 202, 163, 182, 248, 246, 29, 164, 61, 5, 133, 223, 119, 142, 49, 26, 158, 124, 179, 30, 81, 248, 223, 82, 69, 212, 81, 117, 33, 233, 133, 101, 196, 83, 17, 142, 237, 237, 157, 206, 144, 207, 202, 72, 165, 196, 193, 86, 97, 71, 253 }, new byte[] { 42, 229, 201, 96, 119, 79, 30, 249, 234, 6, 39, 65, 162, 27, 36, 224, 150, 112, 89, 185, 7, 214, 42, 174, 102, 7, 137, 119, 81, 54, 154, 179, 156, 47, 159, 112, 93, 162, 27, 228, 85, 148, 73, 154, 79, 28, 108, 228, 230, 145, 83, 233, 72, 242, 20, 76, 210, 64, 253, 118, 172, 197, 190, 125, 212, 191, 9, 169, 185, 34, 162, 82, 87, 164, 11, 101, 152, 154, 186, 98, 187, 185, 224, 54, 172, 202, 171, 177, 66, 148, 211, 137, 251, 210, 106, 32, 98, 69, 253, 94, 147, 223, 138, 122, 255, 58, 221, 106, 4, 52, 129, 228, 86, 37, 255, 52, 164, 139, 42, 250, 26, 5, 236, 109, 205, 161, 194, 134 }, "SUPERVISOR", 3 },
                    { 5, "gf18005@ues.edu.sv", "efrgomez", new byte[] { 123, 221, 62, 86, 10, 33, 58, 211, 138, 186, 150, 13, 115, 248, 202, 163, 182, 248, 246, 29, 164, 61, 5, 133, 223, 119, 142, 49, 26, 158, 124, 179, 30, 81, 248, 223, 82, 69, 212, 81, 117, 33, 233, 133, 101, 196, 83, 17, 142, 237, 237, 157, 206, 144, 207, 202, 72, 165, 196, 193, 86, 97, 71, 253 }, new byte[] { 42, 229, 201, 96, 119, 79, 30, 249, 234, 6, 39, 65, 162, 27, 36, 224, 150, 112, 89, 185, 7, 214, 42, 174, 102, 7, 137, 119, 81, 54, 154, 179, 156, 47, 159, 112, 93, 162, 27, 228, 85, 148, 73, 154, 79, 28, 108, 228, 230, 145, 83, 233, 72, 242, 20, 76, 210, 64, 253, 118, 172, 197, 190, 125, 212, 191, 9, 169, 185, 34, 162, 82, 87, 164, 11, 101, 152, 154, 186, 98, 187, 185, 224, 54, 172, 202, 171, 177, 66, 148, 211, 137, 251, 210, 106, 32, 98, 69, 253, 94, 147, 223, 138, 122, 255, 58, 221, 106, 4, 52, 129, 228, 86, 37, 255, 52, 164, 139, 42, 250, 26, 5, 236, 109, 205, 161, 194, 134 }, "SUPERVISOR", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialPedidos_EstadoPedidoId",
                table: "HistorialPedidos",
                column: "EstadoPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialPedidos_PedidoId",
                table: "HistorialPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumosCategorias_CategoriaId",
                table: "InsumosCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumosCategorias_InsumoId",
                table: "InsumosCategorias",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisesProveedores_PaisId",
                table: "PaisesProveedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisesProveedores_ProveedorId",
                table: "PaisesProveedores",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadoPedidoId",
                table: "Pedidos",
                column: "EstadoPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ProveedorId",
                table: "Pedidos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_SucursalId",
                table: "Pedidos",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosInsumos_InsumoId",
                table: "PedidosInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosInsumos_PedidoId",
                table: "PedidosInsumos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedoresInsumos_InsumoId",
                table: "ProveedoresInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedoresInsumos_ProveedorId",
                table: "ProveedoresInsumos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_PaisId",
                table: "Sucursales",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_SucursalId",
                table: "Usuarios",
                column: "SucursalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialPedidos");

            migrationBuilder.DropTable(
                name: "InsumosCategorias");

            migrationBuilder.DropTable(
                name: "PaisesProveedores");

            migrationBuilder.DropTable(
                name: "PedidosInsumos");

            migrationBuilder.DropTable(
                name: "ProveedoresInsumos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "EstadoPedidos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
