using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforproductsandseedforcigarettes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredients",
                table: "Products",
                newName: "ProductFacts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20175a2b-cb60-4a53-a134-69fbbd367af9"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Jämn och balanserad rökning med distinkt tobakssmak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fe2d4e-95d3-46ad-9c19-12a0d4525453"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Premiumcigarett med elegant och subtil smakprofil." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bc1db67-1f76-44c3-a6ef-8d9aa9627414"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Balanserad smak med en lätt och behaglig rökning." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc3e742-d887-47c3-84f6-01973a01700b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Ikonisk cigarett med distinkt och robust smakprofil." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62ed95db-0f1e-4850-a889-16c66f3a0c0b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Robust och intensiv smakprofil med tydlig tobakston." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69f5cc21-8280-4c49-8928-3e1d1523f8dc"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Kraftfull och fyllig cigarett med en rik och intensiv smakprofil." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("769ff894-42fc-4d84-9dc8-87dcde6e28a2"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Rik och balanserad smak med distinkt tobakskaraktär." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ed318a-2b63-4d5a-8d28-4338b7d542b2"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Mild tobaksblandning med en ren och balanserad smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc5107fc-e2f0-4c14-a2a2-6cf69dc52c39"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Klassisk och robust cigarett med en djup och kraftfull smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e877f4e0-e1d7-491f-9fa4-d7b74a1345c2"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.", "Balanserad och len rökning med distinkt tobakssmak." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductFacts",
                table: "Products",
                newName: "Ingredients");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20175a2b-cb60-4a53-a134-69fbbd367af9"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fe2d4e-95d3-46ad-9c19-12a0d4525453"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bc1db67-1f76-44c3-a6ef-8d9aa9627414"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc3e742-d887-47c3-84f6-01973a01700b"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62ed95db-0f1e-4850-a889-16c66f3a0c0b"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69f5cc21-8280-4c49-8928-3e1d1523f8dc"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("769ff894-42fc-4d84-9dc8-87dcde6e28a2"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ed318a-2b63-4d5a-8d28-4338b7d542b2"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc5107fc-e2f0-4c14-a2a2-6cf69dc52c39"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e877f4e0-e1d7-491f-9fa4-d7b74a1345c2"),
                columns: new[] { "Ingredients", "ShortDescription" },
                values: new object[] { null, null });
        }
    }
}
