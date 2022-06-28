using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "vuminh@gmail.com", "Minh", "0988345678" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 2, "vuminh@gmail.com", "Minh", "0988345678" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 3, "vuminh@gmail.com", "Minh", "0988345678" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
