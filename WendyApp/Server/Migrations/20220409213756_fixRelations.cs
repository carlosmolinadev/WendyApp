using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class fixRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProveedoresInsumos",
                table: "ProveedoresInsumos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidosInsumos",
                table: "PedidosInsumos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaisesProveedores",
                table: "PaisesProveedores");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProveedoresInsumos",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PedidosInsumos",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PaisesProveedores",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProveedoresInsumos",
                table: "ProveedoresInsumos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidosInsumos",
                table: "PedidosInsumos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaisesProveedores",
                table: "PaisesProveedores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedoresInsumos_ProveedorId",
                table: "ProveedoresInsumos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosInsumos_InsumoId",
                table: "PedidosInsumos",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaisesProveedores_PaisId",
                table: "PaisesProveedores",
                column: "PaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProveedoresInsumos",
                table: "ProveedoresInsumos");

            migrationBuilder.DropIndex(
                name: "IX_ProveedoresInsumos_ProveedorId",
                table: "ProveedoresInsumos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidosInsumos",
                table: "PedidosInsumos");

            migrationBuilder.DropIndex(
                name: "IX_PedidosInsumos_InsumoId",
                table: "PedidosInsumos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaisesProveedores",
                table: "PaisesProveedores");

            migrationBuilder.DropIndex(
                name: "IX_PaisesProveedores_PaisId",
                table: "PaisesProveedores");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProveedoresInsumos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PedidosInsumos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PaisesProveedores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProveedoresInsumos",
                table: "ProveedoresInsumos",
                columns: new[] { "ProveedorId", "InsumoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidosInsumos",
                table: "PedidosInsumos",
                columns: new[] { "InsumoId", "PedidoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaisesProveedores",
                table: "PaisesProveedores",
                columns: new[] { "PaisId", "ProveedorId" });
        }
    }
}
