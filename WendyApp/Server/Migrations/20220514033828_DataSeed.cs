using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class DataSeed : Migration
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
                    EstadoPedidosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadoPedidos_EstadoPedidosId",
                        column: x => x.EstadoPedidosId,
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
                    EstadoPedidosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidosId",
                        column: x => x.EstadoPedidosId,
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
                    { 2, "Carnes" }
                });

            migrationBuilder.InsertData(
                table: "Insumos",
                columns: new[] { "InsumoId", "Descripcion", "FechaCreacion", "Nombre" },
                values: new object[] { 1, "Precio por libra", new DateTime(2022, 5, 13, 21, 38, 27, 643, DateTimeKind.Local).AddTicks(1760), "Tomate" });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "PaisId", "Nombre" },
                values: new object[,]
                {
                    { 1, "El Salvador" },
                    { 2, "Guatemala" },
                    { 3, "Costa Rica" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Descripcion", "FechaCreacion", "Nombre" },
                values: new object[] { 1, "Distribuidor de carnes y pan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super selectos" });

            migrationBuilder.InsertData(
                table: "InsumosCategorias",
                columns: new[] { "Id", "CategoriaId", "InsumoId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "PaisesProveedores",
                columns: new[] { "Id", "CostoTransporte", "PaisId", "ProveedorId" },
                values: new object[] { 1, 2.0m, 1, 1 });

            migrationBuilder.InsertData(
                table: "ProveedoresInsumos",
                columns: new[] { "Id", "InsumoId", "Precio", "ProveedorId" },
                values: new object[] { 1, 1, 0.3m, 1 });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[] { 1, "Metrocentro 8va etapa", new DateTime(2022, 5, 13, 21, 38, 27, 638, DateTimeKind.Local).AddTicks(2049), "Sucursal Metrocentro", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[] { 1, "usuario_admin@wendy.com", "admin", new byte[] { 138, 2, 229, 189, 81, 61, 141, 153, 139, 133, 138, 130, 113, 211, 124, 185, 28, 17, 45, 17, 109, 165, 214, 176, 80, 246, 116, 185, 138, 50, 253, 215, 182, 28, 94, 98, 14, 31, 157, 242, 231, 37, 34, 130, 236, 196, 112, 4, 81, 184, 216, 43, 79, 169, 253, 120, 1, 103, 133, 170, 88, 251, 13, 174 }, new byte[] { 166, 35, 127, 98, 213, 174, 134, 102, 195, 65, 190, 130, 131, 92, 38, 246, 207, 227, 238, 207, 137, 8, 175, 15, 212, 86, 71, 91, 110, 146, 71, 186, 126, 111, 60, 58, 10, 174, 79, 199, 72, 68, 40, 191, 183, 0, 37, 27, 184, 149, 111, 200, 123, 156, 158, 22, 219, 224, 192, 213, 23, 167, 68, 7, 100, 102, 11, 200, 144, 46, 250, 47, 64, 242, 186, 166, 90, 198, 13, 162, 205, 49, 202, 38, 254, 194, 9, 190, 211, 153, 250, 248, 21, 96, 168, 90, 168, 172, 83, 163, 35, 52, 251, 175, 194, 45, 232, 224, 11, 78, 14, 57, 69, 54, 227, 9, 12, 42, 138, 63, 117, 7, 182, 35, 26, 209, 151, 16 }, "ADMIN", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[] { 2, "carlos_molina@wendy.com", "carmolina", new byte[] { 138, 2, 229, 189, 81, 61, 141, 153, 139, 133, 138, 130, 113, 211, 124, 185, 28, 17, 45, 17, 109, 165, 214, 176, 80, 246, 116, 185, 138, 50, 253, 215, 182, 28, 94, 98, 14, 31, 157, 242, 231, 37, 34, 130, 236, 196, 112, 4, 81, 184, 216, 43, 79, 169, 253, 120, 1, 103, 133, 170, 88, 251, 13, 174 }, new byte[] { 166, 35, 127, 98, 213, 174, 134, 102, 195, 65, 190, 130, 131, 92, 38, 246, 207, 227, 238, 207, 137, 8, 175, 15, 212, 86, 71, 91, 110, 146, 71, 186, 126, 111, 60, 58, 10, 174, 79, 199, 72, 68, 40, 191, 183, 0, 37, 27, 184, 149, 111, 200, 123, 156, 158, 22, 219, 224, 192, 213, 23, 167, 68, 7, 100, 102, 11, 200, 144, 46, 250, 47, 64, 242, 186, 166, 90, 198, 13, 162, 205, 49, 202, 38, 254, 194, 9, 190, 211, 153, 250, 248, 21, 96, 168, 90, 168, 172, 83, 163, 35, 52, 251, 175, 194, 45, 232, 224, 11, 78, 14, 57, 69, 54, 227, 9, 12, 42, 138, 63, 117, 7, 182, 35, 26, 209, 151, 16 }, "SUPERVISOR", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialPedidos_EstadoPedidosId",
                table: "HistorialPedidos",
                column: "EstadoPedidosId");

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
                name: "IX_Pedidos_EstadoPedidosId",
                table: "Pedidos",
                column: "EstadoPedidosId");

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
