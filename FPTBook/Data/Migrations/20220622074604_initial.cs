using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Name", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Truyen ma", 20000.0, "Truyen ma" },
                    { 2, "De men phuu luu ki", 22000.0, "Truyen tranh" },
                    { 3, "Doraemon", 40000.0, "Truyen tranh" },
                    { 4, "o long vien", 29000.0, "Truyen tranh" },
                    { 5, "It ", 30000.0, "Sach khoa hoc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
