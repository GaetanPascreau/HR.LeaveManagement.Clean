using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class ControlAndCleanApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "Name",
                value: "Administrator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "861f6752-1bfd-416e-85db-e59c2e62af52", "AQAAAAIAAYagAAAAEKbjulVxkNT2Vp57vYJLoJxmH7t20i1YQJVFPQxsWAlqM4zTV/BYRxxRGPycFqme8w==", "60b2f0d0-12d5-498d-b7e7-8a8ebecbdd6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c919e49-42b2-4856-bb4d-7c87a2d71e9f", "AQAAAAIAAYagAAAAEKjs/gYw6Wb69q2R/j/ok6I0bWatouna79PXZr8ttK+CA/ArEWzGnNMlHvxMt/Wi+w==", "0c1a302e-932c-469b-a318-da486eb6d003" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "Name",
                value: "Employee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5a11d00-8251-460e-b8b9-9da29f496bcc", "AQAAAAIAAYagAAAAEFfGeKZFMl8zABmt2gmEqW/JKJuYkcFDc0mcHjpIwg59IHQssAqaNybl+RMw+3eJiw==", "c16d7b5c-e9e0-4c1e-ba5a-dbfdde7b9d24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dbc36aa-acb3-4d43-8ee0-69afeb7c5a89", "AQAAAAIAAYagAAAAEE28zhcIAkIqfrd2FWzw0INc0PC+849EnN7LX+UV/RBdgk02u5iPVOctNuHcDnbvUw==", "3e7a7747-ecc7-446c-89f0-25ed22297921" });
        }
    }
}
