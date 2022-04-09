using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class CreateExternalTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaisProveedor_Paises_PaisesPaisId",
                table: "PaisProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_PaisProveedor_Proveedores_ProveedoresProveedorId",
                table: "PaisProveedor");

            migrationBuilder.DropTable(
                name: "CategoriaInsumo");

            migrationBuilder.DropTable(
                name: "InsumoPedido");

            migrationBuilder.DropTable(
                name: "InsumoProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaisProveedor",
                table: "PaisProveedor");

            migrationBuilder.RenameColumn(
                name: "ProveedoresProveedorId",
                table: "PaisProveedor",
                newName: "ProveedorId");

            migrationBuilder.RenameColumn(
                name: "PaisesPaisId",
                table: "PaisProveedor",
                newName: "PaisId");

            migrationBuilder.RenameIndex(
                name: "IX_PaisProveedor_ProveedoresProveedorId",
                table: "PaisProveedor",
                newName: "IX_PaisProveedor_ProveedorId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PaisProveedor",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaisProveedor",
                table: "PaisProveedor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InsumoCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoCategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsumoCategoria_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoCategoria_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoInsumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoInsumo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoInsumo_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoInsumo_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedorInsumo",
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
                    table.PrimaryKey("PK_ProveedorInsumo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProveedorInsumo_Insumos_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProveedorInsumo_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaisProveedor_PaisId",
                table: "PaisProveedor",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoCategoria_CategoriaId",
                table: "InsumoCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoCategoria_InsumoId",
                table: "InsumoCategoria",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoInsumo_InsumoId",
                table: "PedidoInsumo",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoInsumo_PedidoId",
                table: "PedidoInsumo",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorInsumo_InsumoId",
                table: "ProveedorInsumo",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedorInsumo_ProveedorId",
                table: "ProveedorInsumo",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaisProveedor_Paises_PaisId",
                table: "PaisProveedor",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "PaisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaisProveedor_Proveedores_ProveedorId",
                table: "PaisProveedor",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "ProveedorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaisProveedor_Paises_PaisId",
                table: "PaisProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_PaisProveedor_Proveedores_ProveedorId",
                table: "PaisProveedor");

            migrationBuilder.DropTable(
                name: "InsumoCategoria");

            migrationBuilder.DropTable(
                name: "PedidoInsumo");

            migrationBuilder.DropTable(
                name: "ProveedorInsumo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaisProveedor",
                table: "PaisProveedor");

            migrationBuilder.DropIndex(
                name: "IX_PaisProveedor_PaisId",
                table: "PaisProveedor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PaisProveedor");

            migrationBuilder.RenameColumn(
                name: "ProveedorId",
                table: "PaisProveedor",
                newName: "ProveedoresProveedorId");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                table: "PaisProveedor",
                newName: "PaisesPaisId");

            migrationBuilder.RenameIndex(
                name: "IX_PaisProveedor_ProveedorId",
                table: "PaisProveedor",
                newName: "IX_PaisProveedor_ProveedoresProveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaisProveedor",
                table: "PaisProveedor",
                columns: new[] { "PaisesPaisId", "ProveedoresProveedorId" });

            migrationBuilder.CreateTable(
                name: "CategoriaInsumo",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    InsumosInsumoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaInsumo", x => new { x.CategoriasCategoriaId, x.InsumosInsumoId });
                    table.ForeignKey(
                        name: "FK_CategoriaInsumo_Categorias_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaInsumo_Insumos_InsumosInsumoId",
                        column: x => x.InsumosInsumoId,
                        principalTable: "Insumos",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaInsumo_InsumosInsumoId",
                table: "CategoriaInsumo",
                column: "InsumosInsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoPedido_PedidosPedidoId",
                table: "InsumoPedido",
                column: "PedidosPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoProveedor_ProveedoresProveedorId",
                table: "InsumoProveedor",
                column: "ProveedoresProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaisProveedor_Paises_PaisesPaisId",
                table: "PaisProveedor",
                column: "PaisesPaisId",
                principalTable: "Paises",
                principalColumn: "PaisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaisProveedor_Proveedores_ProveedoresProveedorId",
                table: "PaisProveedor",
                column: "ProveedoresProveedorId",
                principalTable: "Proveedores",
                principalColumn: "ProveedorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
