using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updatedproductwithfeatured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00fa2179-1a79-437e-9514-9e48857f51f5"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07106d71-5e10-47f2-8b11-5da537d62134"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07dd33c3-8a87-4d30-8d84-2d40376c0e43"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08d3cc5b-9ac4-4d8b-b7de-d5c16f1c83b5"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09c13be3-5ed9-4c53-9a51-8cc09e00c08c"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b8d1a2a-bf8c-44d8-8109-741e21962a7b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f64b525-6c14-4815-8a7a-7e202c5352cf"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("130b0491-3cf6-4d52-9d25-8e7c5a7bb31e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16aee36f-d1cb-4979-88fc-b7fc540e8360"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16bca26d-4d89-468b-8f22-90cc5e9b26db"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18dfc76e-6c67-4ec7-a6e9-8347f58577a3"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19c7438b-75eb-43ff-8e5b-75d134142f64"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19cd6f32-1a29-4797-a3f6-86b1a1b2aeb1"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1abf4be2-bac4-4f3f-84d9-f485962a403d"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ea26f7c-bd3c-40a2-a286-9f7b2a570bed"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20175a2b-cb60-4a53-a134-69fbbd367af9"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25e4dc55-6f57-4a6f-bd22-3b4d0cf8ed2f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fe2d4e-95d3-46ad-9c19-12a0d4525453"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0e93d1-739a-4229-b4e1-e7cb2e7b69ac"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e0b90c4-8a10-47e2-9a2f-17432d0790ab"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("341c55fb-1874-4b97-b23a-d9069ed4dc4f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e4481e-12ac-41ae-9dbb-d3b29ac7479b"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36989985-66a1-40da-90d9-ac24e0ab001f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39265ae1-9d07-4e90-b826-9835609ffecb"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bc0101f-1aa3-46e8-8a62-86e9467ff376"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d85573a-5b41-4d3d-9f4f-3ee28dd01e54"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e7ac9e1-c276-4aee-a6b9-68d6898f2b70"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f8dc7e5-2c18-472a-a847-97912e2d0879"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b409ec-32e8-4721-a091-0048e7f7fd4e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1c66d4-9e5d-4cb4-bc87-8c47a4c7a1e0"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51669ac3-fffd-4663-9816-d46016a30a2c"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54494de8-c138-4c62-b87b-cf622fc02ebc"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bc1db67-1f76-44c3-a6ef-8d9aa9627414"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bcf6b1c-bd7e-4e7d-8803-c62db9d5f777"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dc3e742-d887-47c3-84f6-01973a01700b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62ed95db-0f1e-4850-a889-16c66f3a0c0b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b10bb4-6b11-4399-9480-e8c4af7f2064"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67684b6b-7da3-4846-b45c-bd0a46002b27"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67a4d4d0-b6e0-4f4e-a6b1-4ef857d821b3"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6931503e-c3e0-443a-85e5-c2363b9d9c74"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69f5cc21-8280-4c49-8928-3e1d1523f8dc"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0b83db-34aa-4de7-bf2f-3b2aa4c1a14a"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d437f17-22b3-4f1d-b6b1-8a29cb2b9c6f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d663a46-56f2-4c3b-8d2c-8017418ed100"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e860a28-5102-499d-ae76-6d857f77e390"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ef1e7b-52d9-48df-91f5-0819aebc9b4e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("769ff894-42fc-4d84-9dc8-87dcde6e28a2"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79586e5a-8d91-4b6d-8ff2-ae3940640d3b"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ad812f0-5df5-4464-8e0f-cc9b14da1653"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("802d0199-3cd8-4a0d-8fa7-c52b46b0d936"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88a2c83a-f3f8-49a4-99c2-50b9110eb518"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88b2e422-37a9-4d56-8469-d53f780c439b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eab0b08-1898-4b75-a046-a29a84659f10"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91963e79-b529-40c0-94cf-4975e8464c5b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b5a3de-2d08-45cd-b804-88d93117e2c7"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93ffddc9-900c-4736-a9c9-6be1a85989c9"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ed318a-2b63-4d5a-8d28-4338b7d542b2"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c95338e-9a30-4e3d-b80b-bae349a82d69"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c9cbf77-af8b-4224-b4e8-365517d17027"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e0a995a-12a1-448b-95c2-314e1884e57f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3e389d1-5891-4037-8f6b-4922d5a35a60"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad2376e2-cdf2-4bc9-ba35-86e40cd8b97d"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad82dd68-e180-46a7-aa3b-bf8cd908e686"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b293d089-4d2b-4099-9a2c-28cb0a2ef365"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52234d3-d85f-47b5-89ad-d26118d00aaf"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b59e0917-c529-497d-a37d-26b97d8f451f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6b445d0-c4e3-4d69-86e1-d5714d0eb8d7"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7b8c7b8-7896-4ad1-8493-fdbb497b3a4e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8e4cce7-f7bf-4acd-afde-4e9d2f5ac0a8"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba791d95-5d46-4d89-b9c8-2919c063be45"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc5107fc-e2f0-4c14-a2a2-6cf69dc52c39"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf7c6b13-778a-437b-a1b2-54d81aa18d7f"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf8d1562-1cb1-4e02-90eb-927e204ccf2e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c02a7a39-85e5-4d3d-9e11-d66294fc8e5a"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c58f02db-fa44-47d1-97d5-4e1778a12e07"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5ee9149-109f-48c6-b5bc-1de8224b9073"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6141e15-dff1-46a1-a8ec-7a2791212a7b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d45df1-fde9-4b7d-b3dc-186ea8b46f6a"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8966dd2-5bf5-4411-942f-f0a7e6f7f7a5"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca01c900-ff13-47e3-81a4-fdaddc905688"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbdcb109-4f18-4f86-81c2-50b820124c9b"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdaa001f-1848-4ff2-b6dc-8e92b1e59d01"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d03817ec-d049-4903-b026-84c9d33b6f14"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1500077-4fe8-4c17-86a1-92c4a840f7f6"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d43c78e4-eece-40f2-b7cc-4cd161727265"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e6f4d9-85b7-478b-b351-f4a8c063b86c"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8d43af0-02e3-4e58-88fb-7e2260fa06de"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddf823e5-e368-40f4-a747-74592340e6fe"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e07803fb-760a-42a0-8c72-c7cf236c66a0"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c299a9-8026-4c9b-a3c5-ba77d0397ece"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4c2aacc-cd08-4597-97a0-ec7a3d44697c"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51998ad-3426-4ce7-bdfd-297ad6750c5e"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e877f4e0-e1d7-491f-9fa4-d7b74a1345c2"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9d8700d-98a3-4054-a4f3-f9fe779ef07d"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eabf62f8-cb30-45f5-aa14-b63b6c0631e4"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed700aa7-38d8-45b4-80f3-4954696fb999"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee155a6e-bf18-41f0-8ef5-b17719d005af"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f13e2e28-9361-4267-b06c-d03b89290561"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f567409b-f435-4b97-9ba7-51bcf92a4bbf"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7b1049f-463c-41da-a5ff-69f17bbf55cb"),
                column: "IsFeatured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8b08f26-d250-485d-9ebf-25aa4a8fcb49"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e56652-bcc1-40ec-b6cc-b5a2c882e76c"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0c9885-7f4c-4011-a6e1-4c4c838bda45"),
                column: "IsFeatured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe27c2fa-7285-4fb3-9204-0b5b7c87f379"),
                column: "IsFeatured",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");
        }
    }
}
