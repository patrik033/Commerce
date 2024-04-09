using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforproductsandseedforcandy2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25e4dc55-6f57-4a6f-bd22-3b4d0cf8ed2f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 120g", "Tangy sour worms" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0e93d1-739a-4229-b4e1-e7cb2e7b69ac"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 200g", "Indulgent candy bar with peanuts" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1c66d4-9e5d-4cb4-bc87-8c47a4c7a1e0"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 180g", "Colorful candy-coated chocolates" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d437f17-22b3-4f1d-b6b1-8a29cb2b9c6f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 200g", "Assorted fruity jelly beans" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e860a28-5102-499d-ae76-6d857f77e390"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 180g", "Creamy peanut butter cups" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88b2e422-37a9-4d56-8469-d53f780c439b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 150g", "Chewy fruity gummy bears" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e0a995a-12a1-448b-95c2-314e1884e57f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 170g", "Classic wafer fingers in milk chocolate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3e389d1-5891-4037-8f6b-4922d5a35a60"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 100g", "Creamy milk chocolate bar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7b8c7b8-7896-4ad1-8493-fdbb497b3a4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 180g", "Crunchy biscuit sticks with caramel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6141e15-dff1-46a1-a8ec-7a2791212a7b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Net weight: 150g", "Chewy licorice twists" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25e4dc55-6f57-4a6f-bd22-3b4d0cf8ed2f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0e93d1-739a-4229-b4e1-e7cb2e7b69ac"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1c66d4-9e5d-4cb4-bc87-8c47a4c7a1e0"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d437f17-22b3-4f1d-b6b1-8a29cb2b9c6f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e860a28-5102-499d-ae76-6d857f77e390"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88b2e422-37a9-4d56-8469-d53f780c439b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e0a995a-12a1-448b-95c2-314e1884e57f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3e389d1-5891-4037-8f6b-4922d5a35a60"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7b8c7b8-7896-4ad1-8493-fdbb497b3a4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6141e15-dff1-46a1-a8ec-7a2791212a7b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });
        }
    }
}
