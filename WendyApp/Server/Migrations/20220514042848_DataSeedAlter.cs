using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class DataSeedAlter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidosId",
                table: "HistorialPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidosId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "EstadoPedidosId",
                table: "Pedidos",
                newName: "EstadoPedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_EstadoPedidosId",
                table: "Pedidos",
                newName: "IX_Pedidos_EstadoPedidoId");

            migrationBuilder.RenameColumn(
                name: "EstadoPedidosId",
                table: "HistorialPedidos",
                newName: "EstadoPedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_HistorialPedidos_EstadoPedidosId",
                table: "HistorialPedidos",
                newName: "IX_HistorialPedidos_EstadoPedidoId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ProveedoresInsumos",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "PedidosInsumos",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostoTransporte",
                table: "PaisesProveedores",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.InsertData(
                table: "EstadoPedidos",
                columns: new[] { "EstadoPedidoId", "Estado" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "Orden Generada" }
                });

            migrationBuilder.UpdateData(
                table: "Insumos",
                keyColumn: "InsumoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 13, 22, 28, 47, 865, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 13, 22, 28, 47, 865, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 13, 22, 28, 47, 860, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 25, 6, 162, 128, 104, 71, 40, 209, 181, 117, 40, 67, 121, 52, 26, 25, 40, 229, 63, 240, 181, 166, 141, 110, 49, 14, 36, 99, 74, 185, 65, 198, 1, 132, 22, 229, 72, 218, 93, 81, 193, 6, 157, 73, 18, 5, 152, 181, 254, 249, 40, 174, 232, 216, 3, 213, 53, 9, 173, 153, 38, 184, 239 }, new byte[] { 98, 64, 100, 68, 121, 163, 10, 235, 54, 139, 83, 160, 97, 19, 201, 203, 87, 129, 199, 163, 25, 49, 48, 160, 128, 40, 96, 184, 113, 140, 111, 28, 18, 213, 246, 149, 9, 76, 128, 189, 28, 60, 252, 216, 126, 189, 156, 155, 201, 245, 122, 133, 188, 65, 96, 19, 145, 168, 56, 125, 14, 31, 210, 164, 196, 32, 189, 241, 111, 84, 139, 245, 129, 96, 217, 49, 152, 30, 156, 192, 8, 216, 216, 167, 224, 169, 230, 51, 22, 184, 231, 62, 140, 14, 229, 21, 254, 159, 190, 102, 174, 81, 88, 235, 132, 30, 70, 107, 171, 82, 76, 162, 100, 140, 103, 92, 242, 27, 79, 221, 49, 38, 234, 100, 4, 23, 176, 228 } });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 25, 6, 162, 128, 104, 71, 40, 209, 181, 117, 40, 67, 121, 52, 26, 25, 40, 229, 63, 240, 181, 166, 141, 110, 49, 14, 36, 99, 74, 185, 65, 198, 1, 132, 22, 229, 72, 218, 93, 81, 193, 6, 157, 73, 18, 5, 152, 181, 254, 249, 40, 174, 232, 216, 3, 213, 53, 9, 173, 153, 38, 184, 239 }, new byte[] { 98, 64, 100, 68, 121, 163, 10, 235, 54, 139, 83, 160, 97, 19, 201, 203, 87, 129, 199, 163, 25, 49, 48, 160, 128, 40, 96, 184, 113, 140, 111, 28, 18, 213, 246, 149, 9, 76, 128, 189, 28, 60, 252, 216, 126, 189, 156, 155, 201, 245, 122, 133, 188, 65, 96, 19, 145, 168, 56, 125, 14, 31, 210, 164, 196, 32, 189, 241, 111, 84, 139, 245, 129, 96, 217, 49, 152, 30, 156, 192, 8, 216, 216, 167, 224, 169, 230, 51, 22, 184, 231, 62, 140, 14, 229, 21, 254, 159, 190, 102, 174, 81, 88, 235, 132, 30, 70, 107, 171, 82, 76, 162, 100, 140, 103, 92, 242, 27, 79, 221, 49, 38, 234, 100, 4, 23, 176, 228 } });

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidoId",
                table: "HistorialPedidos",
                column: "EstadoPedidoId",
                principalTable: "EstadoPedidos",
                principalColumn: "EstadoPedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidoId",
                table: "Pedidos",
                column: "EstadoPedidoId",
                principalTable: "EstadoPedidos",
                principalColumn: "EstadoPedidoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidoId",
                table: "HistorialPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidoId",
                table: "Pedidos");

            migrationBuilder.DeleteData(
                table: "EstadoPedidos",
                keyColumn: "EstadoPedidoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoPedidos",
                keyColumn: "EstadoPedidoId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "EstadoPedidoId",
                table: "Pedidos",
                newName: "EstadoPedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_EstadoPedidoId",
                table: "Pedidos",
                newName: "IX_Pedidos_EstadoPedidosId");

            migrationBuilder.RenameColumn(
                name: "EstadoPedidoId",
                table: "HistorialPedidos",
                newName: "EstadoPedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_HistorialPedidos_EstadoPedidoId",
                table: "HistorialPedidos",
                newName: "IX_HistorialPedidos_EstadoPedidosId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ProveedoresInsumos",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "PedidosInsumos",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostoTransporte",
                table: "PaisesProveedores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.UpdateData(
                table: "Insumos",
                keyColumn: "InsumoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 13, 21, 38, 27, 643, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Proveedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 13, 21, 38, 27, 638, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 2, 229, 189, 81, 61, 141, 153, 139, 133, 138, 130, 113, 211, 124, 185, 28, 17, 45, 17, 109, 165, 214, 176, 80, 246, 116, 185, 138, 50, 253, 215, 182, 28, 94, 98, 14, 31, 157, 242, 231, 37, 34, 130, 236, 196, 112, 4, 81, 184, 216, 43, 79, 169, 253, 120, 1, 103, 133, 170, 88, 251, 13, 174 }, new byte[] { 166, 35, 127, 98, 213, 174, 134, 102, 195, 65, 190, 130, 131, 92, 38, 246, 207, 227, 238, 207, 137, 8, 175, 15, 212, 86, 71, 91, 110, 146, 71, 186, 126, 111, 60, 58, 10, 174, 79, 199, 72, 68, 40, 191, 183, 0, 37, 27, 184, 149, 111, 200, 123, 156, 158, 22, 219, 224, 192, 213, 23, 167, 68, 7, 100, 102, 11, 200, 144, 46, 250, 47, 64, 242, 186, 166, 90, 198, 13, 162, 205, 49, 202, 38, 254, 194, 9, 190, 211, 153, 250, 248, 21, 96, 168, 90, 168, 172, 83, 163, 35, 52, 251, 175, 194, 45, 232, 224, 11, 78, 14, 57, 69, 54, 227, 9, 12, 42, 138, 63, 117, 7, 182, 35, 26, 209, 151, 16 } });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 2, 229, 189, 81, 61, 141, 153, 139, 133, 138, 130, 113, 211, 124, 185, 28, 17, 45, 17, 109, 165, 214, 176, 80, 246, 116, 185, 138, 50, 253, 215, 182, 28, 94, 98, 14, 31, 157, 242, 231, 37, 34, 130, 236, 196, 112, 4, 81, 184, 216, 43, 79, 169, 253, 120, 1, 103, 133, 170, 88, 251, 13, 174 }, new byte[] { 166, 35, 127, 98, 213, 174, 134, 102, 195, 65, 190, 130, 131, 92, 38, 246, 207, 227, 238, 207, 137, 8, 175, 15, 212, 86, 71, 91, 110, 146, 71, 186, 126, 111, 60, 58, 10, 174, 79, 199, 72, 68, 40, 191, 183, 0, 37, 27, 184, 149, 111, 200, 123, 156, 158, 22, 219, 224, 192, 213, 23, 167, 68, 7, 100, 102, 11, 200, 144, 46, 250, 47, 64, 242, 186, 166, 90, 198, 13, 162, 205, 49, 202, 38, 254, 194, 9, 190, 211, 153, 250, 248, 21, 96, 168, 90, 168, 172, 83, 163, 35, 52, 251, 175, 194, 45, 232, 224, 11, 78, 14, 57, 69, 54, 227, 9, 12, 42, 138, 63, 117, 7, 182, 35, 26, 209, 151, 16 } });

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialPedidos_EstadoPedidos_EstadoPedidosId",
                table: "HistorialPedidos",
                column: "EstadoPedidosId",
                principalTable: "EstadoPedidos",
                principalColumn: "EstadoPedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadoPedidos_EstadoPedidosId",
                table: "Pedidos",
                column: "EstadoPedidosId",
                principalTable: "EstadoPedidos",
                principalColumn: "EstadoPedidoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
