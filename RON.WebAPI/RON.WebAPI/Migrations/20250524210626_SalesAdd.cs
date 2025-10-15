using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RON.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SalesAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    SaleID = table.Column<Guid>(type: "uuid", nullable: false),
                    StoreID = table.Column<Guid>(type: "uuid", nullable: false),
                    UserID = table.Column<Guid>(type: "uuid", nullable: false),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.SaleID);
                    table.ForeignKey(
                        name: "FK_sales_stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "stores",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sales_StoreID",
                table: "sales",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_sales_UserID",
                table: "sales",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sales");
        }
    }
}
