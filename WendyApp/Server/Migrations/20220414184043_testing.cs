using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WendyApp.Server.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 4, 14, 12, 40, 42, 639, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 134, 85, 9, 225, 96, 168, 91, 37, 241, 252, 77, 242, 63, 247, 246, 200, 219, 103, 83, 252, 149, 86, 7, 233, 101, 16, 130, 101, 42, 109, 40, 215, 39, 203, 15, 242, 109, 184, 93, 157, 6, 147, 83, 171, 145, 59, 67, 169, 48, 71, 24, 240, 212, 182, 181, 171, 125, 180, 133, 140, 114, 71, 75, 208 }, new byte[] { 127, 179, 137, 170, 117, 234, 221, 180, 160, 132, 246, 105, 200, 178, 12, 35, 34, 100, 65, 4, 178, 86, 43, 83, 181, 244, 241, 82, 43, 202, 68, 51, 238, 137, 174, 217, 233, 120, 30, 83, 3, 168, 180, 246, 134, 167, 142, 20, 77, 142, 21, 32, 147, 160, 51, 218, 44, 70, 124, 164, 84, 237, 157, 196, 236, 97, 124, 102, 253, 40, 134, 154, 49, 250, 157, 57, 91, 219, 110, 245, 62, 71, 147, 19, 140, 80, 38, 114, 56, 51, 93, 74, 132, 181, 233, 56, 186, 72, 50, 233, 63, 205, 121, 66, 133, 230, 34, 2, 71, 201, 215, 63, 184, 79, 36, 198, 165, 37, 110, 25, 67, 242, 172, 122, 226, 105, 219, 144 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2022, 4, 10, 10, 22, 34, 42, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Password", "PasswordSalt" },
                values: new object[] { new byte[] { 135, 5, 30, 199, 96, 238, 78, 143, 128, 109, 91, 83, 3, 159, 38, 136, 206, 81, 233, 223, 199, 117, 206, 163, 106, 111, 109, 17, 158, 225, 6, 207, 59, 224, 82, 174, 40, 139, 2, 14, 145, 98, 134, 223, 227, 129, 86, 91, 134, 49, 238, 73, 197, 231, 227, 178, 105, 8, 79, 209, 62, 90, 152, 42 }, new byte[] { 103, 53, 23, 212, 3, 45, 165, 237, 38, 11, 107, 157, 180, 109, 106, 186, 72, 30, 210, 121, 155, 139, 106, 100, 50, 115, 69, 186, 156, 141, 251, 184, 220, 212, 229, 133, 47, 250, 238, 48, 210, 26, 127, 172, 171, 157, 203, 126, 50, 149, 53, 19, 212, 17, 26, 59, 230, 62, 187, 0, 16, 177, 55, 30, 184, 101, 29, 209, 29, 121, 224, 148, 170, 57, 211, 75, 202, 99, 87, 56, 105, 174, 245, 99, 170, 2, 16, 251, 145, 3, 235, 91, 154, 177, 26, 196, 119, 5, 241, 19, 113, 46, 114, 83, 158, 238, 101, 87, 122, 183, 73, 46, 31, 42, 56, 193, 117, 66, 130, 116, 120, 240, 57, 58, 145, 114, 190, 149 } });
        }
    }
}
