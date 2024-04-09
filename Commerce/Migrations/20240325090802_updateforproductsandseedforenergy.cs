using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforproductsandseedforenergy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6931503e-c3e0-443a-85e5-c2363b9d9c74"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Högeffektiv energidryck med en läcker smak av blandade bär och en uppiggande blandning av vitaminer och antioxidanter för ökad energi och fokus. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Högeffektiv energidryck." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d663a46-56f2-4c3b-8d2c-8017418ed100"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en balanserad och uppfriskande smak samt en extra boost av koffein för att hjälpa dig att hålla dig vaken och alert under dagen. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Balanserad och uppfriskande smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79586e5a-8d91-4b6d-8ff2-ae3940640d3b"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en unik smakprofil som kombinerar söta och syrliga toner för en intensiv och uppfriskande smakupplevelse. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Unik smakprofil." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ad812f0-5df5-4464-8e0f-cc9b14da1653"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en robust och kryddig smakprofil och en extra kick av koffein för att hjälpa dig att hålla dig vaken och alert. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Robust och kryddig smak." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6b445d0-c4e3-4d69-86e1-d5714d0eb8d7"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Högeffektiv energidryck med en frisk och fruktig smak av apelsin och en extra boost av taurin och koffein för att öka din prestanda och fokus. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Fruktig smak med taurinboost." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8e4cce7-f7bf-4acd-afde-4e9d2f5ac0a8"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Intensiv energidryck med en kraftfull smak och en uppiggande effekt, perfekt för att hålla dig vaken och fokuserad under långa dagar. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Kraftfull energidryck." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8966dd2-5bf5-4411-942f-f0a7e6f7f7a5"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en fruktig smakexplosion av exotiska frukter och en extra boost av koffein för att hålla dig alert och redo för dagen. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Fruktig smakexplosion." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8b08f26-d250-485d-9ebf-25aa4a8fcb49"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Explosiv energidryck med en skarp och intensiv smak som ger dig den extra kick du behöver för att övervinna utmaningarna i din dagliga rutin. Denna produkt är avsedd för personer över laglig ålder.", "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor", "Explosiv smak." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6931503e-c3e0-443a-85e5-c2363b9d9c74"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Högeffektiv energidryck med en läcker smak av blandade bär och en uppiggande blandning av vitaminer och antioxidanter för ökad energi och fokus.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d663a46-56f2-4c3b-8d2c-8017418ed100"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en balanserad och uppfriskande smak samt en extra boost av koffein för att hjälpa dig att hålla dig vaken och alert under dagen.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79586e5a-8d91-4b6d-8ff2-ae3940640d3b"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en unik smakprofil som kombinerar söta och syrliga toner för en intensiv och uppfriskande smakupplevelse.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ad812f0-5df5-4464-8e0f-cc9b14da1653"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en robust och kryddig smakprofil och en extra kick av koffein för att hjälpa dig att hålla dig vaken och alert.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6b445d0-c4e3-4d69-86e1-d5714d0eb8d7"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Högeffektiv energidryck med en frisk och fruktig smak av apelsin och en extra boost av taurin och koffein för att öka din prestanda och fokus.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8e4cce7-f7bf-4acd-afde-4e9d2f5ac0a8"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Intensiv energidryck med en kraftfull smak och en uppiggande effekt, perfekt för att hålla dig vaken och fokuserad under långa dagar.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8966dd2-5bf5-4411-942f-f0a7e6f7f7a5"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Kraftfull energidryck med en fruktig smakexplosion av exotiska frukter och en extra boost av koffein för att hålla dig alert och redo för dagen.", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8b08f26-d250-485d-9ebf-25aa4a8fcb49"),
                columns: new[] { "Description", "ProductFacts", "ShortDescription" },
                values: new object[] { "Explosiv energidryck med en skarp och intensiv smak som ger dig den extra kick du behöver för att övervinna utmaningarna i din dagliga rutin.", null, null });
        }
    }
}
