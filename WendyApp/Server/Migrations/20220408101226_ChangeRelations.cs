using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class ChangeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsumoCategorias");

            migrationBuilder.DropTable(
                name: "PaisProveedores");

            migrationBuilder.DropTable(
                name: "PedidoInsumos");

            migrationBuilder.DropTable(
                name: "ProveedorInsumos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId1",
                table: "Categorias",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsumoId",
                table: "Categorias",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InsumoPedido",
                columns: table => new
                {
                    InsumosInsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PedidosPedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoPedido", x => new { x.InsumosInsumoId, x.PedidosPedidoId });
                    table.ForeignKey(
                        name: "FK_InsumoPedido_Insumos_InsumosInsumoId",
                        column: x => x.InsumosInsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoPedido_Pedidos_PedidosPedidoId",
                        column: x => x.PedidosPedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsumoProveedor",
                columns: table => new
                {
                    InsumosInsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProveedoresProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoProveedor", x => new { x.InsumosInsumoId, x.ProveedoresProveedorId });
                    table.ForeignKey(
                        name: "FK_InsumoProveedor_Insumos_InsumosInsumoId",
                        column: x => x.InsumosInsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoProveedor_Proveedores_ProveedoresProveedorId",
                        column: x => x.ProveedoresProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaisProveedor",
                columns: table => new
                {
                    PaisesPaisId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProveedoresProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisProveedor", x => new { x.PaisesPaisId, x.ProveedoresProveedorId });
                    table.ForeignKey(
                        name: "FK_PaisProveedor_Paises_PaisesPaisId",
                        column: x => x.PaisesPaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisProveedor_Proveedores_ProveedoresProveedorId",
                        column: x => x.ProveedoresProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaId1",
                table: "Categorias",
                column: "CategoriaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_InsumoId",
                table: "Categorias",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoPedido_PedidosPedidoId",
                table: "InsumoPedido",
                column: "PedidosPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoProveedor_ProveedoresProveedorId",
                table: "InsumoProveedor",
                column: "ProveedoresProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisProveedor_ProveedoresProveedorId",
                table: "PaisProveedor",
                column: "ProveedoresProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId1",
                table: "Categorias",
                column: "CategoriaId1",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Insumos_InsumoId",
                table: "Categorias",
                column: "InsumoId",
                principalTable: "Insumos",
                principalColumn: "InsumoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId1",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Insumos_InsumoId",
                table: "Categorias");

            migrationBuilder.DropTable(
                name: "InsumoPedido");

            migrationBuilder.DropTable(
                name: "InsumoProveedor");

            migrationBuilder.DropTable(
                name: "PaisProveedor");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaId1",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_InsumoId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId1",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "InsumoId",
                table: "Categorias");

            migrationBuilder.CreateTable(
                name: "InsumoCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsumoCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoCategorias_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaisProveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PaisId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaisProveedores_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisProveedores_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoInsumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoInsumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoInsumos_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoInsumos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedorInsumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Preciocompra = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    ProveedorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorInsumos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProveedorInsumos_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProveedorInsumos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsumoCategorias_CategoriaId",
                table: "InsumoCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoCategorias_InsumoId",
                table: "InsumoCategorias",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisProveedores_PaisId",
                table: "PaisProveedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisProveedores_ProveedorId",
                table: "PaisProveedores",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoInsumos_InsumoId",
                table: "PedidoInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoInsumos_PedidoId",
                table: "PedidoInsumos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorInsumos_InsumoId",
                table: "ProveedorInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorInsumos_ProveedorId",
                table: "ProveedorInsumos",
                column: "ProveedorId");
        }
    }
}
