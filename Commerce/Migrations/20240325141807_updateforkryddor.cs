using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforkryddor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00fa2179-1a79-437e-9514-9e48857f51f5"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller nikotin", "Traditionell snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07106d71-5e10-47f2-8b11-5da537d62134"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att krydda grytor och soppor.", "Aromatisk och jordig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07dd33c3-8a87-4d30-8d84-2d40376c0e43"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekta för att tillsätta smak och knaprighet till sallader, tacos och burgare.", "Färska och krispiga." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08d3cc5b-9ac4-4d8b-b7de-d5c16f1c83b5"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller rosmarin, timjan, mejram och dragon.", "Klassisk mix för franska rätter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09c13be3-5ed9-4c53-9a51-8cc09e00c08c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller tobaksextrakt", "Klassisk snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b8d1a2a-bf8c-44d8-8109-741e21962a7b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Används ofta i kötträtter och soppor.", "Aromatisk och jordig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f64b525-6c14-4815-8a7a-7e202c5352cf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller kryddpeppar, kanel, muskotnöt och habaneropeppar.", "Aromatisk mix för karibiska rätter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("130b0491-3cf6-4d52-9d25-8e7c5a7bb31e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Låg fuktighet", "Mild och frisk snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16aee36f-d1cb-4979-88fc-b7fc540e8360"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller rökig smak med en hint av sötma", "Kryddig BBQ-sås från Kansas City" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16bca26d-4d89-468b-8f22-90cc5e9b26db"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Helt fri från tobak", "Tobaksfri snus med mintsmak" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19c7438b-75eb-43ff-8e5b-75d134142f64"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en kraftfull och robust smak.", "Handplockade och ekologiskt odlade." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19cd6f32-1a29-4797-a3f6-86b1a1b2aeb1"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt till fisk och såser.", "Färsk och krispig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e0b90c4-8a10-47e2-9a2f-17432d0790ab"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Hög nikotinhalt", "Kraftfull snus med mintsmak" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("341c55fb-1874-4b97-b23a-d9069ed4dc4f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Tillverkad enligt svenska traditioner", "Klassisk svensk snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e4481e-12ac-41ae-9dbb-d3b29ac7479b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Klassiskt svenskt recept", "Robust snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39265ae1-9d07-4e90-b826-9835609ffecb"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekta för att strö över sallader och bakverk.", "Knapriga och krämiga." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bc0101f-1aa3-46e8-8a62-86e9467ff376"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en intensiv och fyllig smak.", "Grovmald och kryddig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d85573a-5b41-4d3d-9f4f-3ee28dd01e54"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ren tobakssmak", "Mild och rund snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e7ac9e1-c276-4aee-a6b9-68d6898f2b70"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en intensiv och robust smak.", "Handplockade och ekologiskt odlade." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f8dc7e5-2c18-472a-a847-97912e2d0879"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller ingefära, vitlök, sojasås och sesamfrön.", "Aromatisk mix för asiatisk wok." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b409ec-32e8-4721-a091-0048e7f7fd4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekta för att strö över sallader och soppor.", "Knaperiga och smakrika." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51669ac3-fffd-4663-9816-d46016a30a2c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Låg fuktighet för långvarig smak", "Extra stark snus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bcf6b1c-bd7e-4e7d-8803-c62db9d5f777"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller currypulver, gurkmeja, spiskummin och koriander.", "Doftande mix för indisk curry." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b10bb4-6b11-4399-9480-e8c4af7f2064"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Fruktig och mild", "Frisk och söt snus med melonsmak" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67684b6b-7da3-4846-b45c-bd0a46002b27"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att toppa sallader och wraps.", "Krämig och smakrik." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67a4d4d0-b6e0-4f4e-a6b1-4ef857d821b3"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Passar bra i asiatiska rätter och salsa.", "Aromatisk och citrusliknande." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0b83db-34aa-4de7-bf2f-3b2aa4c1a14a"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller chilipulver, spiskummin, paprika och vitlök.", "Kryddig mix för tacos och burritos." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ef1e7b-52d9-48df-91f5-0819aebc9b4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en rik och distinkt smak.", "Kryddig och aromatisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("802d0199-3cd8-4a0d-8fa7-c52b46b0d936"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en rik och robust smak.", "Finmald och aromatisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88a2c83a-f3f8-49a4-99c2-50b9110eb518"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekta för att strö över sallader och asiatiska rätter.", "Smakrika och knapriga." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91963e79-b529-40c0-94cf-4975e8464c5b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller persilja, timjan, basilika och oregano.", "Smakfull mix för medelhavsrätter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b5a3de-2d08-45cd-b804-88d93117e2c7"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller eldig cayennepeppar och paprika", "Eldig Cajun kryddblandning" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c95338e-9a30-4e3d-b80b-bae349a82d69"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en härlig smak till rostat kött.", "Aromatisk och talliknande." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c9cbf77-af8b-4224-b4e8-365517d17027"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en intensiv och kryddig smak.", "Handplockade och ekologiskt odlade." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller basilika, oregano, rosmarin och timjan.", "Klassisk italiensk örtblandning för pasta och pizza." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad82dd68-e180-46a7-aa3b-bf8cd908e686"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en djup och fyllig smak.", "Finmald och kraftfull." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b293d089-4d2b-4099-9a2c-28cb0a2ef365"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Används ofta i italienska rätter.", "Aromatisk och fräsch." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52234d3-d85f-47b5-89ad-d26118d00aaf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Naturlig och distinkt smak.", "Ekologisk och hållbart producerad." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b59e0917-c529-497d-a37d-26b97d8f451f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller rökt paprika och lök", "Rökig kryddblandning med chipotle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba791d95-5d46-4d89-b9c8-2919c063be45"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att krydda sallader, fisk och kyckling.", "Aromatisk och frisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf7c6b13-778a-437b-a1b2-54d81aa18d7f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Används ofta i bakning och till desserter.", "Doftande och blommig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf8d1562-1cb1-4e02-90eb-927e204ccf2e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att dressa sallader och marinader.", "Robust och aromatisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c58f02db-fa44-47d1-97d5-4e1778a12e07"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller doftande vitlök och kryddig rosmarin", "Vitlök och örtmarinad för grillning" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5ee9149-109f-48c6-b5bc-1de8224b9073"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att dressa sallader och grillat kött.", "Söt och syrlig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d45df1-fde9-4b7d-b3dc-186ea8b46f6a"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller timjan, sumak, sesamfrön och oregano.", "Doftande mix för Mellanösterns kök." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca01c900-ff13-47e3-81a4-fdaddc905688"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller lavendel, mejram, libbsticka och timjan.", "Traditionell mix för franska rätter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdaa001f-1848-4ff2-b6dc-8e92b1e59d01"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en rik och robust smak.", "Kryddig och aromatisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03817ec-d049-4903-b026-84c9d33b6f14"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att krydda drycker och desserter.", "Färsk och uppfriskande." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e6f4d9-85b7-478b-b351-f4a8c063b86c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Ger en rik och distinkt smak.", "Kryddig och aromatisk." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8d43af0-02e3-4e58-88fb-7e2260fa06de"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Klassiskt tillbehör till soppor och såser.", "Färsk och pepprig." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e07803fb-760a-42a0-8c72-c7cf236c66a0"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Klassiskt tillbehör till pizza och pasta.", "Aromatisk och robust." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4c2aacc-cd08-4597-97a0-ec7a3d44697c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att ge sallader en extra smakboost.", "Härlig blandning av kryddor och örter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9d8700d-98a3-4054-a4f3-f9fe779ef07d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Perfekt för att dressa sallader och pasta.", "Kvalitativ och smakrik." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eabf62f8-cb30-45f5-aa14-b63b6c0631e4"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller lönnsirap och bourbonwhiskey", "Rik glasyr med lönnsirap och bourbon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed700aa7-38d8-45b4-80f3-4954696fb999"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller gurkmeja, ingefära, spiskummin och koriander.", "Doftande mix för asiatisk curry." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f13e2e28-9361-4267-b06c-d03b89290561"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller paprika, vitlökspulver och cayennepeppar", "Klassisk kryddblandning för grillning" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f567409b-f435-4b97-9ba7-51bcf92a4bbf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Innehåller bourbonwhiskey och senap", "Söt glasyr med honung och bourbon" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00fa2179-1a79-437e-9514-9e48857f51f5"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07106d71-5e10-47f2-8b11-5da537d62134"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07dd33c3-8a87-4d30-8d84-2d40376c0e43"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08d3cc5b-9ac4-4d8b-b7de-d5c16f1c83b5"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09c13be3-5ed9-4c53-9a51-8cc09e00c08c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b8d1a2a-bf8c-44d8-8109-741e21962a7b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f64b525-6c14-4815-8a7a-7e202c5352cf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("130b0491-3cf6-4d52-9d25-8e7c5a7bb31e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16aee36f-d1cb-4979-88fc-b7fc540e8360"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16bca26d-4d89-468b-8f22-90cc5e9b26db"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19c7438b-75eb-43ff-8e5b-75d134142f64"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19cd6f32-1a29-4797-a3f6-86b1a1b2aeb1"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e0b90c4-8a10-47e2-9a2f-17432d0790ab"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("341c55fb-1874-4b97-b23a-d9069ed4dc4f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e4481e-12ac-41ae-9dbb-d3b29ac7479b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39265ae1-9d07-4e90-b826-9835609ffecb"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bc0101f-1aa3-46e8-8a62-86e9467ff376"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d85573a-5b41-4d3d-9f4f-3ee28dd01e54"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e7ac9e1-c276-4aee-a6b9-68d6898f2b70"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f8dc7e5-2c18-472a-a847-97912e2d0879"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b409ec-32e8-4721-a091-0048e7f7fd4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51669ac3-fffd-4663-9816-d46016a30a2c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bcf6b1c-bd7e-4e7d-8803-c62db9d5f777"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b10bb4-6b11-4399-9480-e8c4af7f2064"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67684b6b-7da3-4846-b45c-bd0a46002b27"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67a4d4d0-b6e0-4f4e-a6b1-4ef857d821b3"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0b83db-34aa-4de7-bf2f-3b2aa4c1a14a"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ef1e7b-52d9-48df-91f5-0819aebc9b4e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("802d0199-3cd8-4a0d-8fa7-c52b46b0d936"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88a2c83a-f3f8-49a4-99c2-50b9110eb518"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91963e79-b529-40c0-94cf-4975e8464c5b"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b5a3de-2d08-45cd-b804-88d93117e2c7"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c95338e-9a30-4e3d-b80b-bae349a82d69"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c9cbf77-af8b-4224-b4e8-365517d17027"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad82dd68-e180-46a7-aa3b-bf8cd908e686"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b293d089-4d2b-4099-9a2c-28cb0a2ef365"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52234d3-d85f-47b5-89ad-d26118d00aaf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b59e0917-c529-497d-a37d-26b97d8f451f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba791d95-5d46-4d89-b9c8-2919c063be45"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf7c6b13-778a-437b-a1b2-54d81aa18d7f"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf8d1562-1cb1-4e02-90eb-927e204ccf2e"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c58f02db-fa44-47d1-97d5-4e1778a12e07"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5ee9149-109f-48c6-b5bc-1de8224b9073"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d45df1-fde9-4b7d-b3dc-186ea8b46f6a"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca01c900-ff13-47e3-81a4-fdaddc905688"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdaa001f-1848-4ff2-b6dc-8e92b1e59d01"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03817ec-d049-4903-b026-84c9d33b6f14"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e6f4d9-85b7-478b-b351-f4a8c063b86c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8d43af0-02e3-4e58-88fb-7e2260fa06de"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e07803fb-760a-42a0-8c72-c7cf236c66a0"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4c2aacc-cd08-4597-97a0-ec7a3d44697c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9d8700d-98a3-4054-a4f3-f9fe779ef07d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eabf62f8-cb30-45f5-aa14-b63b6c0631e4"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed700aa7-38d8-45b4-80f3-4954696fb999"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f13e2e28-9361-4267-b06c-d03b89290561"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f567409b-f435-4b97-9ba7-51bcf92a4bbf"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });
        }
    }
}
