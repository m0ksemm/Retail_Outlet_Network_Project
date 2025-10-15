using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RON.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SalesProductsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleproducts_users_ProductID",
                table: "saleproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_saleproducts_products_ProductID",
                table: "saleproducts",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleproducts_products_ProductID",
                table: "saleproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_saleproducts_users_ProductID",
                table: "saleproducts",
                column: "ProductID",
                principalTable: "users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
