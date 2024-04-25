using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class updatedApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3e134a-2c3a-446f-86af-112d26fd2890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "022ab774-e6ff-4df6-8024-c4bfcabbca15", "AQAAAAIAAYagAAAAEImBuKJa2rgPR6oDX+Vi3bvJ1VWLG5b5f1do1xH8xsmx6+05IB/GTJV5r6xJsZtN+Q==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d18002c7-dab3-4987-89a2-2b64b467bfc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3e139a-1c7a-446f-86af-112d26fd2899",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "05d76503-ccc8-41ea-9eed-9a4b2d46ff67", "AQAAAAIAAYagAAAAECC/peuXbt+X4USlJbZ7ipVJl6D6PmNBNhYTPhYtI4TKgq4mptk99Mn8eTkPNq1orA==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "73abfa0f-2707-4c1b-91e3-4bb7ce97c1f3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3e134a-2c3a-446f-86af-112d26fd2890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7d84ef-6a66-4e6e-948d-b25bf18748b4", "AQAAAAIAAYagAAAAEK4wYUmV8DFuSdjSn0qo0wCbpbzlyn6RXif+bQfqeL/gFjFUF181RM0GMFV8WDLTqQ==", "0a79d111-e657-4f8d-9cab-e2683ee28ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3e139a-1c7a-446f-86af-112d26fd2899",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc165aee-e7fd-4008-87f0-b54dd7efe475", "AQAAAAIAAYagAAAAEGNweOBgXPt/LZOAeJapKKCSq2pTeLtzAsUYMExwXsUnBZU8alfbJLPo7b9bQGXCDA==", "df13f3b7-fa31-419b-b99c-ddcfeeb060be" });
        }
    }
}
