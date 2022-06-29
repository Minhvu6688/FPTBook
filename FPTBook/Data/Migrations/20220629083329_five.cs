using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "Amount", "Price" },
                values: new object[] { 6, 6, 24000f });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 6, "custumer@gmail.com", "Nguyen Thi Linh", "0866046619" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CartId", "CustomerId", "Name", "Price", "Title" },
                values: new object[] { 6, 6, 6, "It ", 30000f, "Sach khoa hoc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
