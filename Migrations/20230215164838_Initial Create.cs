using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JashimToken.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { -1, new byte[] { 163, 222, 196, 35, 98, 150, 124, 43, 88, 164, 219, 220, 182, 48, 94, 186, 255, 168, 253, 203, 83, 42, 144, 28, 252, 254, 38, 179, 231, 237, 84, 101, 181, 39, 95, 46, 63, 121, 29, 111, 81, 88, 38, 97, 137, 31, 33, 21, 135, 247, 164, 124, 234, 102, 3, 12, 49, 195, 218, 218, 104, 250, 46, 222 }, new byte[] { 238, 35, 166, 121, 252, 251, 32, 153, 18, 55, 15, 161, 214, 154, 189, 118, 14, 148, 140, 146, 142, 97, 165, 83, 249, 252, 134, 116, 198, 43, 53, 245, 83, 239, 22, 124, 124, 182, 168, 234, 21, 177, 69, 50, 247, 181, 217, 30, 141, 204, 40, 184, 19, 229, 219, 87, 134, 118, 235, 129, 140, 145, 189, 126, 125, 50, 238, 165, 88, 109, 36, 98, 249, 150, 77, 200, 40, 69, 228, 213, 201, 144, 81, 109, 85, 118, 241, 232, 46, 240, 90, 131, 58, 22, 104, 229, 251, 90, 97, 24, 110, 190, 78, 238, 173, 76, 7, 205, 17, 67, 81, 122, 134, 59, 151, 133, 161, 180, 231, 192, 75, 183, 141, 236, 205, 133, 98, 74 }, "Jashim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
