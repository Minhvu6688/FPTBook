using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customer",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://radiotruyen.info/upload/cover/thumbnail_wm/Bao-Mong-Truyen-Ma-Kinh-Di.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://i.ytimg.com/vi/VM03KHkVXuc/maxresdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://m.media-amazon.com/images/M/MV5BYzIzOWQ3NDYtOTFlOC00OGMwLTgwZWItNWI2ZDlmZGEwNGQ3XkEyXkFqcGdeQXVyODAzNzAwOTU@.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://1.bp.blogspot.com/-0nneT6gz6EU/YLunEqXZSUI/AAAAAAAAAJE/RNzZLQq9zBUsFXHCHUmZK0eZln87RPWMQCLcBGAsYHQ/w0/5.jpeg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "");
        }
    }
}
