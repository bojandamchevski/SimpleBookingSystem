using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookedQuantity", "DateFrom", "DateTo", "ResourceId" },
                values: new object[] { 1, 12, new DateTime(2021, 11, 28, 16, 12, 26, 106, DateTimeKind.Local).AddTicks(6766), new DateTime(2021, 12, 3, 16, 12, 26, 110, DateTimeKind.Local).AddTicks(8920), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
