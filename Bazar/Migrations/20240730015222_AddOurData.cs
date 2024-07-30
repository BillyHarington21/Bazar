using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bazar.Migrations
{
    /// <inheritdoc />
    public partial class AddOurData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Fruits" },
                    { 2, "Vegetables" },
                    { 3, "Dairy" },
                    { 4, "Baked Goods" },
                    { 5, "Beverages" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Apple", 1.20m },
                    { 2, 1, "Banana", 0.50m },
                    { 3, 1, "Orange", 0.80m },
                    { 4, 2, "Broccoli", 1.00m },
                    { 5, 2, "Carrot", 0.30m },
                    { 6, 3, "Milk", 1.50m },
                    { 7, 3, "Cheese", 2.50m },
                    { 8, 4, "Bread", 1.00m },
                    { 9, 4, "Cake", 3.00m },
                    { 10, 5, "Coffee", 4.00m },
                    { 11, 5, "Tea", 2.00m },
                    { 12, 5, "Soda", 1.00m },
                    { 13, 3, "Yogurt", 1.20m },
                    { 14, 2, "Spinach", 0.80m },
                    { 15, 1, "Grapes", 2.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
