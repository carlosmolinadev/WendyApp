using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class FirstDeploy : Migration
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
                    Preciocompra = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
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
                    CostoTransporte = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
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
                values: new object[] { 1, "El Salvador" });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "PaisId", "Nombre" },
                values: new object[] { 2, "Guatemala" });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "FechaCreacion", "Nombre", "PaisId" },
                values: new object[] { 1, "Metrocentro 8va etapa", new DateTime(2022, 4, 10, 10, 22, 34, 42, DateTimeKind.Local).AddTicks(5715), "Sucursal Metrocentro", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Nickname", "Password", "PasswordSalt", "Rol", "SucursalId" },
                values: new object[] { 1, "usuario_admin@wendy.com", "admin", new byte[] { 135, 5, 30, 199, 96, 238, 78, 143, 128, 109, 91, 83, 3, 159, 38, 136, 206, 81, 233, 223, 199, 117, 206, 163, 106, 111, 109, 17, 158, 225, 6, 207, 59, 224, 82, 174, 40, 139, 2, 14, 145, 98, 134, 223, 227, 129, 86, 91, 134, 49, 238, 73, 197, 231, 227, 178, 105, 8, 79, 209, 62, 90, 152, 42 }, new byte[] { 103, 53, 23, 212, 3, 45, 165, 237, 38, 11, 107, 157, 180, 109, 106, 186, 72, 30, 210, 121, 155, 139, 106, 100, 50, 115, 69, 186, 156, 141, 251, 184, 220, 212, 229, 133, 47, 250, 238, 48, 210, 26, 127, 172, 171, 157, 203, 126, 50, 149, 53, 19, 212, 17, 26, 59, 230, 62, 187, 0, 16, 177, 55, 30, 184, 101, 29, 209, 29, 121, 224, 148, 170, 57, 211, 75, 202, 99, 87, 56, 105, 174, 245, 99, 170, 2, 16, 251, 145, 3, 235, 91, 154, 177, 26, 196, 119, 5, 241, 19, 113, 46, 114, 83, 158, 238, 101, 87, 122, 183, 73, 46, 31, 42, 56, 193, 117, 66, 130, 116, 120, 240, 57, 58, 145, 114, 190, 149 }, "ADMIN", 1 });

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
