using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefualtStock = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesPrice = table.Column<float>(type: "real", nullable: false),
                    PurchasePrice = table.Column<float>(type: "real", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7b9beb8e-d7b3-4f1a-bf23-88ecab2ebb4d"), "James" },
                    { new Guid("8a4c6d84-2dc3-4477-855b-51ccb581db27"), "John" },
                    { new Guid("9368eaf9-5ed7-480d-807f-cc229b4b8c35"), "Anderson" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "description", "name", "photo", "type" },
                values: new object[,]
                {
                    { new Guid("26d8877a-85ea-45da-8322-dfceeffee12f"), "", "Cold", "", "out of stock" },
                    { new Guid("37923fe5-c699-4ce6-83bc-2e6ac9890c04"), "", "Headache", "", "out of stock" },
                    { new Guid("ee1f2eb0-7f69-4738-acfc-ab19a5244c5f"), "", "Stress", "", "out of stock" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogProducts_ProductsId",
                table: "CatalogProducts",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductsId",
                table: "ProductDetails",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogProducts");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
