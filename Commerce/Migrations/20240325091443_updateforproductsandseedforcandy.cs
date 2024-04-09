using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updateforproductsandseedforcandy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1abf4be2-bac4-4f3f-84d9-f485962a403d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Innehåller gluten\n- Ej lämplig för personer med glutenintolerans\n- Kan innehålla spår av gelatin", "Salta lakritsfiskar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ea26f7c-bd3c-40a2-a286-9f7b2a570bed"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och soja\n- Ej lämplig för personer med allergier mot mjölk eller soja", "Mjukt skumgodis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93ffddc9-900c-4736-a9c9-6be1a85989c9"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Kan innehålla spår av gelatin\n- Ej lämplig för personer med känslig magslemhinna\n- Överdriven konsumtion kan vara skadlig för tänderna", "Små syrliga surisar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad2376e2-cdf2-4bc9-ba35-86e40cd8b97d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och soja\n- Ej lämplig för personer med allergier mot jordgubbar", "Söta jordgubbsremmar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddf823e5-e368-40f4-a747-74592340e6fe"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Innehåller gluten\n- Ej lämplig för personer med glutenintolerans\n- Kan innehålla spår av gelatin", "Klassiska lakritssnören." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee155a6e-bf18-41f0-8ef5-b17719d005af"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Kan innehålla spår av gelatin\n- Ej lämplig för personer med känslig magslemhinna\n- Överdriven konsumtion kan vara skadlig för tänderna", "Syrliga surkolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7b1049f-463c-41da-a5ff-69f17bbf55cb"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av gluten\n- Ej lämplig för personer med gelatinallergi", "Saftiga geléhallon." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e56652-bcc1-40ec-b6cc-b5a2c882e76c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Kan innehålla spår av ägg och mjölk\n- Ej lämplig för personer med ägg- eller mjölkallergi\n- Överdriven konsumtion kan vara skadlig för tänderna", "Krispiga marängsviss." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0c9885-7f4c-4011-a6e1-4c4c838bda45"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Innehåller mjölk och nötter\n- Kan innehålla spår av gluten och soja\n- Ej lämplig för personer med allergier mot mjölk eller nötter", "Lyxiga chokladpraliner." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe27c2fa-7285-4fb3-9204-0b5b7c87f379"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och nötter\n- Ej lämplig för personer med allergier mot mjölk eller nötter", "Mjuka karamellkolor." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1abf4be2-bac4-4f3f-84d9-f485962a403d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ea26f7c-bd3c-40a2-a286-9f7b2a570bed"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93ffddc9-900c-4736-a9c9-6be1a85989c9"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad2376e2-cdf2-4bc9-ba35-86e40cd8b97d"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddf823e5-e368-40f4-a747-74592340e6fe"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee155a6e-bf18-41f0-8ef5-b17719d005af"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7b1049f-463c-41da-a5ff-69f17bbf55cb"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e56652-bcc1-40ec-b6cc-b5a2c882e76c"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0c9885-7f4c-4011-a6e1-4c4c838bda45"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe27c2fa-7285-4fb3-9204-0b5b7c87f379"),
                columns: new[] { "ProductFacts", "ShortDescription" },
                values: new object[] { null, null });
        }
    }
}
