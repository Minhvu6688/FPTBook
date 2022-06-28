using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBook.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Book_bookIdId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Customer_customerIdId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_bookIdId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_customerIdId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "bookIdId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "customerIdId",
                table: "Cart");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Book",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "Name", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Lama1", 20000f, "Truyen ma" },
                    { 2, "Lama2", 25000f, "Truyen ma" },
                    { 3, "Lama3", 27000f, "Sach Khoa hoc" },
                    { 4, "Lama4", 27000f, "Sach Khoa hoc" },
                    { 5, "Lama5", 27000f, "Sach Khoa hoc" }
                });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "minhlc@gmail.com", "Nguyen Van Minh", "0866046616" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "admin@gmail.com", "Nguyen Van Binh", "0866046617" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "custumer@gmail.com", "Nguyen Thi Linh", "0866046618" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 4, "custumer@gmail.com", "Nguyen Thi Linh", "0866046618" },
                    { 5, "custumer@gmail.com", "Nguyen Thi Linh", "0866046618" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CartId", "CustomerId", "Price" },
                values: new object[] { 1, 1, 20000f });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CartId", "CustomerId", "Price" },
                values: new object[] { 2, 2, 22000f });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CartId", "CustomerId", "Price" },
                values: new object[] { 3, 3, 40000f });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CartId", "CustomerId", "Price" },
                values: new object[] { 4, 4, 29000f });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CartId", "CustomerId", "Price" },
                values: new object[] { 5, 5, 30000f });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CartId",
                table: "Book",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CustomerId",
                table: "Book",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Cart_CartId",
                table: "Book",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Cart_CartId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_CartId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_CustomerId",
                table: "Book");

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "bookIdId",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerIdId",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Book",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 20000.0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 22000.0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 40000.0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 29000.0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 30000.0);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "vuminh@gmail.com", "Minh", "0988345678" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "vuminh@gmail.com", "Minh", "0988345678" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "vuminh@gmail.com", "Minh", "0988345678" });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_bookIdId",
                table: "Cart",
                column: "bookIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_customerIdId",
                table: "Cart",
                column: "customerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Book_bookIdId",
                table: "Cart",
                column: "bookIdId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Customer_customerIdId",
                table: "Cart",
                column: "customerIdId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
