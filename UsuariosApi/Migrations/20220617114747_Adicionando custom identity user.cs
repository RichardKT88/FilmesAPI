using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "af24cb82-4afb-4e03-9350-9e8c3f164cd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "b0f1069f-6a69-4ea1-aa39-45037a84b0d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39264a70-35f8-49e7-8026-d0fa9a667129", "AQAAAAEAACcQAAAAEFH/LlXrvW4O5Eq5bGOZWdUQ08xxvvXZ1MNpGzcODIqiuMRLioV/eQenyZTigWzMRw==", "f5a4a16e-9392-4c8f-a788-d4d4b347c40d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "2edfb031-075c-4bbe-a55f-4c34d12accb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d09b3d68-f2f1-43d1-8fb3-c264e0d897bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "663ddf99-bcec-4c7b-a331-20c78cf2dc1f", "AQAAAAEAACcQAAAAEN+g+JgnGZPlOu8eGuezZXMm0E3VZC2nHR7jSpzGHyrn8jBcL+nGCOU6W5iVFdg+xg==", "fb8668e3-d099-4a31-910f-a7d5d08e7b24" });
        }
    }
}
