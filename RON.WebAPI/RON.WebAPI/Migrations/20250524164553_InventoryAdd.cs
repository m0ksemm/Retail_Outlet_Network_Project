using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RON.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InventoryAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    InventoryID = table.Column<Guid>(type: "uuid", nullable: false),
                    StoreID = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductID = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_inventory_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventory_stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "stores",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventory_ProductID",
                table: "inventory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_StoreID",
                table: "inventory",
                column: "StoreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventory");
        }
    }
}
