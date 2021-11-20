using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedBooking2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 17, 52, 272, DateTimeKind.Local).AddTicks(6566), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookedQuantity", "DateFrom", "DateTo", "ResourceId" },
                values: new object[,]
                {
                    { 2, 5, new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7808), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7828), 3 },
                    { 3, 4, new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7840), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7842), 4 },
                    { 4, 2, new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7845), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7848), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 12, 26, 106, DateTimeKind.Local).AddTicks(6766), new DateTime(2021, 12, 3, 16, 12, 26, 110, DateTimeKind.Local).AddTicks(8920) });
        }
    }
}
