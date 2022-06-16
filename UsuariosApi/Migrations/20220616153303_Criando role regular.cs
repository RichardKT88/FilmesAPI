using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6b153b7f-f26b-4a51-be90-c743db0d91d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "ae208f85-a51a-4e86-9600-038478867811", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da24a11c-90c9-44f9-bda6-bc38084f06d6", "AQAAAAEAACcQAAAAENHDnxAXolL0Nz5/rFDqbC0/fBAuknSLMia08Xb6vq1qYldpuyaiG/4JCeAQrN97GQ==", "d3d590e0-7f78-4d36-a274-5fb63d85a21d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "41279931-afe6-427d-a609-61db4495dd41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83a53df-1875-42f4-9511-7d9eba0b9b20", "AQAAAAEAACcQAAAAECvi1KO0mUGNLDj3V36fWaX9UyCcrs6HeRYKiqQ5m8T26V/1N/9JU1kK4r0IsGfjbA==", "79cd80b6-3111-4f1c-8ca0-abdf44b6bab2" });
        }
    }
}
