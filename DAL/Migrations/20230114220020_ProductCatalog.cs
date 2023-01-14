using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ProductCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catalogs_CatalogId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatalogId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "CatalogProducts",
                columns: table => new
                {
                    CatalogsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogProducts", x => new { x.CatalogsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CatalogProducts_Catalogs_CatalogsId",
                        column: x => x.CatalogsId,
                        principalTable: "Catalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogProducts_ProductsId",
                table: "CatalogProducts",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "CatalogId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatalogId",
                table: "Products",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catalogs_CatalogId",
                table: "Products",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id");
        }
    }
}
