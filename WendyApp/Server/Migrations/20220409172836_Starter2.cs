using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class Starter2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InsumosCategorias",
                table: "InsumosCategorias");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "InsumosCategorias",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsumosCategorias",
                table: "InsumosCategorias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_InsumosCategorias_InsumoId",
                table: "InsumosCategorias",
                column: "InsumoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InsumosCategorias",
                table: "InsumosCategorias");

            migrationBuilder.DropIndex(
                name: "IX_InsumosCategorias_InsumoId",
                table: "InsumosCategorias");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "InsumosCategorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsumosCategorias",
                table: "InsumosCategorias",
                columns: new[] { "InsumoId", "CategoriaId" });
        }
    }
}
