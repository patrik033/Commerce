using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updatedApplicationUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3e134a-2c3a-446f-86af-112d26fd2890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f2025af-bd1e-4db3-aebc-115a17672954", "AQAAAAIAAYagAAAAEGWl5Gu8u/ste/lC0UH0ipRSkMQsHEPDR1iisMyMfLe4mGjfw5L8oTmDLbM2xXD13Q==", "1f81045f-ff21-4278-a8d4-d05bcdf36035" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3e139a-1c7a-446f-86af-112d26fd2899",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb09f074-69e4-4332-b675-1a76169388d5", "AQAAAAIAAYagAAAAEJSpgWWcE9bYUwPGUz5kbd79Xt2JlO95hqXf2fCHL3dUDJBHTDHFohGJjkheDF3W9Q==", "51d28d83-b588-4058-871a-8518439415a3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3e134a-2c3a-446f-86af-112d26fd2890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "022ab774-e6ff-4df6-8024-c4bfcabbca15", "AQAAAAIAAYagAAAAEImBuKJa2rgPR6oDX+Vi3bvJ1VWLG5b5f1do1xH8xsmx6+05IB/GTJV5r6xJsZtN+Q==", "d18002c7-dab3-4987-89a2-2b64b467bfc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3e139a-1c7a-446f-86af-112d26fd2899",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05d76503-ccc8-41ea-9eed-9a4b2d46ff67", "AQAAAAIAAYagAAAAECC/peuXbt+X4USlJbZ7ipVJl6D6PmNBNhYTPhYtI4TKgq4mptk99Mn8eTkPNq1orA==", "73abfa0f-2707-4c1b-91e3-4bb7ce97c1f3" });
        }
    }
}
