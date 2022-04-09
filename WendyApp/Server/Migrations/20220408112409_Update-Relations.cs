using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class UpdateRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId1",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Insumos_InsumoId",
                table: "Categorias");

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaInsumo_InsumosInsumoId",
                table: "CategoriaInsumo",
                column: "InsumosInsumoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaInsumo");

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

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaId1",
                table: "Categorias",
                column: "CategoriaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_InsumoId",
                table: "Categorias",
                column: "InsumoId");

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
    }
}
