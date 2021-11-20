using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class TestRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 42, 13, 581, DateTimeKind.Local).AddTicks(7963), new DateTime(2021, 12, 3, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6122), new DateTime(2021, 12, 3, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6156), new DateTime(2021, 12, 3, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 12, 3, 16, 42, 13, 585, DateTimeKind.Local).AddTicks(6166) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 17, 52, 272, DateTimeKind.Local).AddTicks(6566), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7808), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7840), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2021, 11, 28, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7845), new DateTime(2021, 12, 3, 16, 17, 52, 277, DateTimeKind.Local).AddTicks(7848) });
        }
    }
}
