using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RON.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SalesProductsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "saleproducts",
                columns: table => new
                {
                    SaleProductID = table.Column<Guid>(type: "uuid", nullable: false),
                    SaleID = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductID = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleproducts", x => x.SaleProductID);
                    table.ForeignKey(
                        name: "FK_saleproducts_sales_SaleID",
                        column: x => x.SaleID,
                        principalTable: "sales",
                        principalColumn: "SaleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saleproducts_users_ProductID",
                        column: x => x.ProductID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_saleproducts_ProductID",
                table: "saleproducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_saleproducts_SaleID",
                table: "saleproducts",
                column: "SaleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "saleproducts");
        }
    }
}
