using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Cart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 2, 21000f });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 3, 22000f });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 4, 23000f });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 5, 24000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Title" },
                values: new object[] { "Lama1", "Truyen ma" });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Title" },
                values: new object[] { "Lama2", 25000f, "Truyen ma" });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Title" },
                values: new object[] { "Lama3", 27000f, "Sach Khoa hoc" });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Title" },
                values: new object[] { "Lama4", 27000f, "Sach Khoa hoc" });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Title" },
                values: new object[] { "Lama5", 27000f, "Sach Khoa hoc" });
        }
    }
}
