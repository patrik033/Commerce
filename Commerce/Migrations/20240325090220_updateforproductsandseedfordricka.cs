using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforproductsandseedfordricka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18dfc76e-6c67-4ec7-a6e9-8347f58577a3"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Dr Pepper är en distinkt blandning av 23 smaker som skapar en unik och tillfredsställande smakupplevelse som har gjort den till en favorit bland dryckesälskare. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Innehåller koffein.", "Unik blandning av 23 smaker." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36989985-66a1-40da-90d9-ac24e0ab001f"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Mountain Dew är en djärv och citrusig soda med en kick av koffein för en energigivande boost som håller dig igång hela dagen. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Innehåller koffein.", "Citrusig soda med koffeinboost." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54494de8-c138-4c62-b87b-cf622fc02ebc"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Schweppes Tonic Water är ett krispigt och bubblande tonicvatten perfekt för att mixa med gin eller vodka och skapa en uppfriskande och läskande drink. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Bäst serverad med is.", "Bubblande tonicvatten." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eab0b08-1898-4b75-a046-a29a84659f10"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Gatorade Lemon-Lime är en elektrolytpackad dryck som hjälper till att återställa vätskebalansen och elektrolyterna efter träning. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Innehåller elektrolyter.", "Elektrolytpack." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c02a7a39-85e5-4d3d-9e11-d66294fc8e5a"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Lipton Iced Tea är en förfriskande iste med en balanserad och lätt söt smak som är perfekt för att njuta av på en varm sommardag eller som ett uppiggande alternativ till kaffe. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Innehåller naturliga smakämnen.", "Förfriskande iste." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbdcb109-4f18-4f86-81c2-50b820124c9b"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Sprite är en krispig och klar citron-lime soda med en uppfriskande smak som är idealisk för att stilla din törst och lämna dig känslan uppfriskad. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Bäst serverad väl kyld.", "Krispig citron-lime soda." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1500077-4fe8-4c17-86a1-92c4a840f7f6"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Coca-Cola är en klassisk coladryck med en unik och förfriskande smak som har varit en favorit bland dryckesälskare över hela världen i generationer. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Bäst serverad kyld.", "Klassisk coladryck med unik smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d43c78e4-eece-40f2-b7cc-4cd161727265"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Pepsi är en uppfriskande coladryck med en fräsch och djärv smak, perfekt för att stilla din törst på en varm sommardag eller som en uppiggande dryck under arbetet. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Förvaras svalt för bästa smakupplevelse.", "Frisk coladryck med en djärv smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c299a9-8026-4c9b-a3c5-ba77d0397ece"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Nestea Peach är en lätt och fruktig persikais med en uppfriskande smak och en mild sötma som gör den till det perfekta valet för att stilla din törst på en solig dag. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Innehåller naturliga smakämnen.", "Fruktig persikais." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51998ad-3426-4ce7-bdfd-297ad6750c5e"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Fanta Orange är en tangy och söt apelsindryck som spricker av fruktig smak och är perfekt för att njuta av en het sommardag eller som en uppfriskande dryck under träning. Denna dryck är lämplig för personer i alla åldrar.", "Produktfakta: Skaka flaskan före öppning för bästa smak.", "Söt och fruktig apelsindryck." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18dfc76e-6c67-4ec7-a6e9-8347f58577a3"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "En distinkt blandning av 23 smaker skapar en unik och tillfredsställande smakupplevelse som har gjort Dr Pepper till en favorit bland dryckesälskare.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36989985-66a1-40da-90d9-ac24e0ab001f"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Djärv och citrusig soda med en kick av koffein för en energigivande boost som håller dig igång hela dagen.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54494de8-c138-4c62-b87b-cf622fc02ebc"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Krispig och bubblande tonicvatten perfekt för att mixa med gin eller vodka och skapa en uppfriskande och läskande drink.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eab0b08-1898-4b75-a046-a29a84659f10"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Elektrolytpack", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c02a7a39-85e5-4d3d-9e11-d66294fc8e5a"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Förfriskande iste med en balanserad och lätt söt smak som är perfekt för att njuta av på en varm sommardag eller som ett uppiggande alternativ till kaffe.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbdcb109-4f18-4f86-81c2-50b820124c9b"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Krispig och klar citron-lime soda med en uppfriskande smak som är idealisk för att stilla din törst och lämna dig känslan uppfriskad.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1500077-4fe8-4c17-86a1-92c4a840f7f6"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Klassisk coladryck med en unik och förfriskande smak som har varit en favorit bland dryckesälskare över hela världen i generationer.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d43c78e4-eece-40f2-b7cc-4cd161727265"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Uppfriskande coladryck med en fräsch och djärv smak, perfekt för att stilla din törst på en varm sommardag eller som en uppiggande dryck under arbetet.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c299a9-8026-4c9b-a3c5-ba77d0397ece"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Lätt och fruktig persikais med en uppfriskande smak och en mild sötma som gör den till det perfekta valet för att stilla din törst på en solig dag.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51998ad-3426-4ce7-bdfd-297ad6750c5e"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Tangy och söt apelsindryck som spricker av fruktig smak och är perfekt för att njuta av en het sommardag eller som en uppfriskande dryck under träning.", null, null });
        }
    }
}
