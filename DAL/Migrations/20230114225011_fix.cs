using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("7b9beb8e-d7b3-4f1a-bf23-88ecab2ebb4d"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("8a4c6d84-2dc3-4477-855b-51ccb581db27"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("9368eaf9-5ed7-480d-807f-cc229b4b8c35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26d8877a-85ea-45da-8322-dfceeffee12f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37923fe5-c699-4ce6-83bc-2e6ac9890c04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee1f2eb0-7f69-4738-acfc-ab19a5244c5f"));

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f8203f3-8717-4cdf-bf1f-588fbc13971d"), "John" },
                    { new Guid("1fc5acb3-fcd0-45f2-b3ea-62e006eeab0c"), "James" },
                    { new Guid("27880c8b-a53e-411b-a29b-328bf56905c2"), "Anderson" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "description", "name", "photo", "type" },
                values: new object[,]
                {
                    { new Guid("3cf3091e-485a-40b6-b4fd-b4ea2d730d63"), "", "Stress", "", "out of stock" },
                    { new Guid("6c55a09c-bcc3-488d-9814-b43fc445dc1d"), "", "Cold", "", "out of stock" },
                    { new Guid("83dff502-7c7d-4f27-83ed-d2eb25cbb3c6"), "", "Headache", "", "out of stock" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("0f8203f3-8717-4cdf-bf1f-588fbc13971d"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("1fc5acb3-fcd0-45f2-b3ea-62e006eeab0c"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("27880c8b-a53e-411b-a29b-328bf56905c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cf3091e-485a-40b6-b4fd-b4ea2d730d63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c55a09c-bcc3-488d-9814-b43fc445dc1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83dff502-7c7d-4f27-83ed-d2eb25cbb3c6"));

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
        }
    }
}
