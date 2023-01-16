using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class productDetailsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductsId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ProductsId",
                table: "ProductDetails");

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("62848bbb-7ba9-489a-950e-366bbfd80c4a"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("c1410567-184c-4ed2-a1d6-4a2dd20e3726"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e9048982-5246-437e-b6e5-22914242404a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b48ea2c-5d6e-453f-9438-4b97b86219f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb8ca34-76e1-47bc-820a-e0ca0370e74c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e01fa83e-61da-46b9-9052-d813a1eebb22"));

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_Id",
                table: "ProductDetails",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_Id",
                table: "ProductDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductsId",
                table: "ProductDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("62848bbb-7ba9-489a-950e-366bbfd80c4a"), "Anderson" },
                    { new Guid("c1410567-184c-4ed2-a1d6-4a2dd20e3726"), "James" },
                    { new Guid("e9048982-5246-437e-b6e5-22914242404a"), "John" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "description", "name", "photo", "type" },
                values: new object[,]
                {
                    { new Guid("8b48ea2c-5d6e-453f-9438-4b97b86219f7"), "", "Cold", "", "out of stock" },
                    { new Guid("cfb8ca34-76e1-47bc-820a-e0ca0370e74c"), "", "Stress", "", "out of stock" },
                    { new Guid("e01fa83e-61da-46b9-9052-d813a1eebb22"), "", "Headache", "", "out of stock" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductsId",
                table: "ProductDetails",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductsId",
                table: "ProductDetails",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
