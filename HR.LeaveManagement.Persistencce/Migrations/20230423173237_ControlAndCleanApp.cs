using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistencce.Migrations
{
    /// <inheritdoc />
    public partial class ControlAndCleanApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 23, 19, 32, 37, 632, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 4, 23, 19, 32, 37, 632, DateTimeKind.Local).AddTicks(2520) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 9, 34, 6, 158, DateTimeKind.Utc).AddTicks(86), new DateTime(2023, 4, 13, 9, 34, 6, 158, DateTimeKind.Utc).AddTicks(89) });
        }
    }
}
