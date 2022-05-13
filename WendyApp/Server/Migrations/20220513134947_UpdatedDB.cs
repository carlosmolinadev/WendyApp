using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class UpdatedDB : Migration
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
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Precio = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
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
                values: new object[] { 1, "Vegetales" });

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
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[] { 1, "Metrocentro 8va etapa", new DateTime(2022, 5, 13, 7, 49, 47, 234, DateTimeKind.Local).AddTicks(5033), "Sucursal Metrocentro", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[] { 1, "usuario_admin@wendy.com", "admin", new byte[] { 213, 4, 3, 13, 5, 62, 10, 130, 4, 60, 30, 157, 33, 78, 43, 25, 153, 222, 134, 50, 115, 239, 136, 193, 222, 201, 212, 121, 25, 250, 195, 14, 107, 50, 152, 33, 147, 119, 210, 171, 141, 48, 125, 236, 135, 9, 16, 215, 215, 34, 221, 226, 190, 31, 251, 174, 165, 168, 234, 90, 117, 10, 101, 32 }, new byte[] { 250, 10, 48, 46, 124, 120, 139, 58, 9, 103, 200, 233, 227, 230, 172, 35, 90, 91, 78, 100, 88, 167, 82, 235, 142, 40, 62, 194, 204, 9, 236, 223, 43, 82, 76, 173, 176, 157, 47, 168, 224, 50, 34, 141, 18, 149, 202, 61, 113, 0, 107, 144, 215, 98, 234, 86, 166, 251, 42, 182, 51, 214, 99, 133, 102, 145, 215, 145, 248, 66, 113, 35, 86, 20, 0, 206, 112, 227, 56, 37, 30, 241, 109, 171, 136, 216, 145, 43, 70, 16, 183, 195, 88, 114, 87, 168, 127, 160, 89, 187, 50, 244, 231, 2, 212, 180, 47, 221, 120, 176, 62, 141, 110, 108, 247, 145, 184, 5, 210, 30, 226, 140, 243, 136, 66, 102, 146, 239 }, "ADMIN", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[] { 2, "carlos_molina@wendy.com", "carmolina", new byte[] { 213, 4, 3, 13, 5, 62, 10, 130, 4, 60, 30, 157, 33, 78, 43, 25, 153, 222, 134, 50, 115, 239, 136, 193, 222, 201, 212, 121, 25, 250, 195, 14, 107, 50, 152, 33, 147, 119, 210, 171, 141, 48, 125, 236, 135, 9, 16, 215, 215, 34, 221, 226, 190, 31, 251, 174, 165, 168, 234, 90, 117, 10, 101, 32 }, new byte[] { 250, 10, 48, 46, 124, 120, 139, 58, 9, 103, 200, 233, 227, 230, 172, 35, 90, 91, 78, 100, 88, 167, 82, 235, 142, 40, 62, 194, 204, 9, 236, 223, 43, 82, 76, 173, 176, 157, 47, 168, 224, 50, 34, 141, 18, 149, 202, 61, 113, 0, 107, 144, 215, 98, 234, 86, 166, 251, 42, 182, 51, 214, 99, 133, 102, 145, 215, 145, 248, 66, 113, 35, 86, 20, 0, 206, 112, 227, 56, 37, 30, 241, 109, 171, 136, 216, 145, 43, 70, 16, 183, 195, 88, 114, 87, 168, 127, 160, 89, 187, 50, 244, 231, 2, 212, 180, 47, 221, 120, 176, 62, 141, 110, 108, 247, 145, 184, 5, 210, 30, 226, 140, 243, 136, 66, 102, 146, 239 }, "SUPERVISOR", 1 });

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
