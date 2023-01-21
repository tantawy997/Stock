using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class changecatalogname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogProducts");

            migrationBuilder.CreateTable(
                name: "CatalogsProducts",
                columns: table => new
                {
                    CatalogsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogsProducts", x => new { x.CatalogsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CatalogsProducts_Catalogs_CatalogsId",
                        column: x => x.CatalogsId,
                        principalTable: "Catalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogsProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogsProducts_ProductsId",
                table: "CatalogsProducts",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogsProducts");

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
    }
}
